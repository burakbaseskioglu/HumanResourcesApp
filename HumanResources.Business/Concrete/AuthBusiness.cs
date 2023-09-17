using AutoMapper;
using HumanResources.Business.Abstract;
using HumanResources.Core.Utilities.Result;
using HumanResources.Core.Utilities.Security;
using HumanResources.Core.Utilities.Security.EncryptDecrypt;
using HumanResources.Core.Utilities.Security.Hashing;
using HumanResources.DataAccess.Abstract;
using HumanResources.Entities.Concrete;
using HumanResources.Entities.Dto.Auth;

namespace HumanResources.Business.Concrete
{
    public class AuthBusiness : IAuthBusiness
    {
        private readonly IUserBusiness _userBusiness;
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
        private readonly IEncryption _encryption;

        public AuthBusiness(IUserBusiness userBusiness, IUserRepository userRepository, IMapper mapper, IEncryption encryption)
        {
            _userBusiness = userBusiness;
            _userRepository = userRepository;
            _mapper = mapper;
            _encryption = encryption;
        }

        public IDataResult<string> GenerateKey()
        {
            var key = _encryption.GenerateKey();
            return new SuccessDataResult<string>(key);
        }

        public IResult Login(LoginDto loginDto)
        {
            var checkUserFromDb = _userRepository.Get(x => x.Email == loginDto.Email);

            if (checkUserFromDb != null)
            {
                var passwordHash = new PasswordHash();
                var getHash = checkUserFromDb.Password.Split('æ')[0];
                var getSalt = checkUserFromDb.Password.Split('æ')[1];
                var checkPassword = passwordHash.VerifyHash(loginDto.Password, getHash, getSalt);

                if (checkPassword)
                {
                    return new SuccessResult();
                }

                return new ErrorResult("Girilen parola hatalı");
            }

            return new ErrorResult("Kullanıcı bulunamadı.");
        }

        public async Task<IResult> Register(RegisterDto userInsertDto)
        {
            var checkUserFromDb = _userRepository.Get(x => x.Email == userInsertDto.Email || x.IdentityNumber == userInsertDto.IdentityNumber);

            if (checkUserFromDb == null)
            {
                if (userInsertDto.Password.Trim() == userInsertDto.PasswordAgain.Trim())
                {
                    var nviResult = await _userBusiness.CheckUserFromNvi(userInsertDto);

                    if (nviResult.Success)
                    {
                        var user = _mapper.Map<User>(userInsertDto);

                        var passwordHash = new PasswordHash();
                        var generateSalt = passwordHash.GenerateSaltHash();
                        user.Password = passwordHash.CreateHash(user.Password, generateSalt);

                        var userPublicKey = _encryption.GenerateKey();
                        var encryptedUserPublicKey = _encryption.EncryptText(userPublicKey, EncryptionConstant.EncryptionPrivateKey);

                        var encryptedIdentityNumber = _encryption.EncryptText(user.IdentityNumber.ToString(), userPublicKey);
                        var encryptedPhoneNumber = _encryption.EncryptText(user.Phone, userPublicKey);
                        var encryptedEmail = _encryption.EncryptText(user.Email, userPublicKey);

                        user.IdentityNumber = encryptedIdentityNumber;
                        user.Phone = encryptedPhoneNumber;
                        user.Email = encryptedEmail;
                        user.PublicKey = encryptedUserPublicKey;

                        _userRepository.Insert(user);
                        return new SuccessResult();
                    }
                    return new ErrorResult(nviResult.Message);
                }
                return new ErrorResult("Girilen parolalar eşleşmiyor.");
            }

            return new ErrorResult("Bu e-posta adresi ile daha önce kayıt olundu.");
        }
    }
}
