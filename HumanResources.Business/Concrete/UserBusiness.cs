using AutoMapper;
using HumanResources.Business.Abstract;
using HumanResources.Core.Utilities.Result;
using HumanResources.DataAccess.Abstract;
using HumanResources.Entities.Dto.Auth;
using HumanResources.Entities.Dto.User;
using NviServiceReference;

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

    public IResult Delete(Guid userId)
    {
        var findUser = _userRepository.Get(x => x.Id == userId);

        if (findUser != null)
        {
            _userRepository.Delete(findUser);
            return new SuccessResult();
        }

        return new ErrorResult("Kullanıcı bulunamadı.");
    }

    public IDataResult<IEnumerable<UserDto>> GetAll()
    {
        var findUser = _userRepository.GetAll();

        if (findUser != null)
        {
            var user = _mapper.Map<IEnumerable<UserDto>>(findUser);
            return new SuccessDataResult<IEnumerable<UserDto>>(user);
        }

        return new ErrorDataResult<IEnumerable<UserDto>>("Kullanıcı bulunamadı.");
    }

    public IDataResult<UserDto> GetUserById(Guid id)
    {
        var findUser = _userRepository.Get(x => x.Id == id);

        if (findUser != null)
        {
            var user = _mapper.Map<UserDto>(findUser);
            return new SuccessDataResult<UserDto>(user);
        }

        return new ErrorDataResult<UserDto>("Kullanıcı bulunamadı.");
    }

    public IDataResult<UserIdentityDto> GetUserCredentials()
    {
        var findUser = _userRepository.Get(x => x.Id == Guid.Parse("9b66dfbe-cb4d-4078-bde2-bc7a96fb24da"));

        if (findUser != null)
        {
            var user = _mapper.Map<UserIdentityDto>(findUser);
            return new SuccessDataResult<UserIdentityDto>(user);
        }

        return new ErrorDataResult<UserIdentityDto>("Kullanıcı bulunamadı.");
    }

    public IResult Update(UserUpdateDto userUpdateDto)
    {
        var user = _userRepository.Get(x => x.Id == userUpdateDto.Id);

        if (user != null)
        {
            var updatedUser = _mapper.Map(userUpdateDto, user);
            _userRepository.Update(updatedUser);
            return new SuccessResult();
        }

        return new ErrorResult("Kullanıcı bulunamadı.");
    }

    public async Task<IResult> CheckUserFromNvi(RegisterDto userInsertDto)
    {
        using KPSPublicSoapClient nviClient = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);

        var result = await nviClient.TCKimlikNoDogrulaAsync(userInsertDto.IdentityNumber, userInsertDto.Firstname, userInsertDto.Lastname, userInsertDto.DateOfBirth.Year);

        if (result.Body.TCKimlikNoDogrulaResult)
        {
            return new SuccessResult();
        }

        return new ErrorResult("Kimlik bilgileri doğrulanamadı.");
    }
}
