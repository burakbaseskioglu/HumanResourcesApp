using HumanResources.Core.Utilities.Result;
using HumanResources.Entities.Dto.User;

namespace HumanResources.Business.Abstract
{
    public interface IUserBusiness
    {
        IResult Insert(UserInsertDto userInsertDto);
        IDataResult<IEnumerable<UserDto>> GetAll();
        IResult Delete(Guid workId);
        IResult Update(UserUpdateDto userUpdateDto);
        IDataResult<UserDto> GetUserById(Guid id);
        IDataResult<UserIdentityDto> GetUserCredentials();
    }
}
