using AutoMapper;
using HumanResources.Business.Abstract;
using HumanResources.Core.Utilities.Result;
using HumanResources.DataAccess.Abstract;
using HumanResources.Entities.Dto.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResources.Business.Concrete;

public class UserBusiness : IUserBusiness
{
    private readonly IUserRepository _userRepository;
    private readonly IMapper _mapper;

    public UserBusiness(IUserRepository userRepository, IMapper mapper)
    {
        _userRepository = userRepository;
        _mapper = mapper;
    }

    public IResult Delete(Guid workId)
    {
        throw new NotImplementedException();
    }

    public IDataResult<IEnumerable<UserDto>> GetAll()
    {
        throw new NotImplementedException();
    }

    public IDataResult<UserDto> GetUserById(Guid id)
    {
        throw new NotImplementedException();
    }

    public IDataResult<UserIdentityDto> GetUserCredentials()
    {
        throw new NotImplementedException();
    }

    public IResult Insert(UserInsertDto userInsertDto)
    {
        throw new NotImplementedException();
    }

    public IResult Update(UserUpdateDto userUpdateDto)
    {
        throw new NotImplementedException();
    }
}
