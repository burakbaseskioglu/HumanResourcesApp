using HumanResources.Core.Utilities.Result;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Cryptography;
using System.Text;

namespace HumanResources.Core.Utilities.Security.Jwt
{
    public class TokenService : ITokenService
    {
        private readonly IOptions<JwtTokenOptions> _jwtTokenOptions;
        private static DateTime _accessTokenExpireDate = DateTime.Now.AddMinutes(20);

        public TokenService(IOptions<JwtTokenOptions> jwtTokenOptions)
        {
            _jwtTokenOptions = jwtTokenOptions;
        }

        public IDataResult<AccessToken> CreateAccessToken()
        {
            var securityKey = _jwtTokenOptions.Value.SecretKey;
            var symmetricSecurityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(securityKey));
            var signingCredentials = new SigningCredentials(symmetricSecurityKey, SecurityAlgorithms.HmacSha256Signature);

            var jwtToken = new JwtSecurityToken(
                    issuer: _jwtTokenOptions.Value.Issuer,
                    audience: _jwtTokenOptions.Value.Audience,
                    signingCredentials: signingCredentials,
                    expires:_accessTokenExpireDate,
                    notBefore:DateTime.Now
                );
            var tokenHandler = new JwtSecurityTokenHandler();
            var token = tokenHandler.WriteToken(jwtToken);

            if (!string.IsNullOrEmpty(token))
            {
                var accessToken = new AccessToken
                {
                    access_token = token,
                    expire_time = _accessTokenExpireDate
                };

                return new SuccessDataResult<AccessToken>(accessToken);
            }

            return new ErrorDataResult<AccessToken>("Token oluşturalamadı.");
        }

        public IDataResult<RefreshToken> CreateRefreshToken()
        {
            using(var randomNumberGenerator = RandomNumberGenerator.Create())
            {
                var randomNumber = new byte[32];
                randomNumberGenerator.GetBytes(randomNumber);
                var refreshToken= new RefreshToken
                {
                    refresh_token = Convert.ToBase64String(randomNumber),
                    expire_time = _accessTokenExpireDate.AddMinutes(5)
                };

                return new SuccessDataResult<RefreshToken>(refreshToken);
            }
        }
    }
}
