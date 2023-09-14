using HumanResources.Core.Utilities.Result;
using HumanResources.Entities.Dto.Auth;

namespace HumanResources.Business.Abstract
{
    public interface IAuthBusiness
    {
        Task<IResult> Register(RegisterDto userInsertDto);
        IResult Login(LoginDto loginDto);
        IDataResult<string> GenerateKey();
    }
}
