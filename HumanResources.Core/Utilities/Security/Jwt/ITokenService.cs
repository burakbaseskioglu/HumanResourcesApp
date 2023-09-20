using HumanResources.Core.Utilities.Result;

namespace HumanResources.Core.Utilities.Security.Jwt
{
    public interface ITokenService
    {
        IDataResult<AccessToken> CreateAccessToken();
        IDataResult<RefreshToken> CreateRefreshToken();
    }
}
