using HumanResources.Core.Utilities.Result;
using HumanResources.Entities.Dto.Auth;
using HumanResources.Entities.Dto.User;

namespace HumanResources.Business.Abstract
{
    public interface IUserBusiness
    {
        IDataResult<IEnumerable<UserDto>> GetAll();
        IResult Delete(Guid userId);
        IResult Update(UserUpdateDto userUpdateDto);
        IDataResult<UserDto> GetUserById(Guid id);
        IDataResult<UserIdentityDto> GetUserCredentials();
        Task<IResult> CheckUserFromNvi(RegisterDto userInsertDto);
    }
}
