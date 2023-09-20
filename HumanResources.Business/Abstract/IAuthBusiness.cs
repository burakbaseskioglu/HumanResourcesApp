using HumanResources.Core.Utilities.Result;
using HumanResources.Core.Utilities.Security.Jwt;
using HumanResources.Entities.Dto.Auth;

namespace HumanResources.Business.Abstract
{
    public interface IAuthBusiness
    {
        Task<IResult> Register(RegisterDto userInsertDto);
        IDataResult<AccessToken> Login(LoginDto loginDto);
        IDataResult<string> GenerateKey();
        IDataResult<AccessToken> GenerateAccessTokenWithRefreshToken(string refreshToken);
    }
}
