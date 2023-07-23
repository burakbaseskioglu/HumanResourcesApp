using System.Security.Cryptography;
using System.Text;

namespace HumanResources.Core.Utilities.Security.Hashing
{
    public class PasswordHash
    {
        private const int _keySize = 64;
        private const int _iteration = 10000;

        public string CreateHash(string password, string salt)
        {
            var hash = Rfc2898DeriveBytes.Pbkdf2(
                password: Encoding.UTF8.GetBytes(password),
                salt: Encoding.UTF8.GetBytes(salt),
                iterations: _iteration,
                hashAlgorithm: HashAlgorithmName.SHA512,
                outputLength: _keySize);

            return $"{Convert.ToBase64String(hash)}æ{salt}";
        }

        public string GenerateSaltHash()
        {
            using var numberGenerator = RandomNumberGenerator.Create();
            byte[] randomBytes = new byte[_keySize / 2];
            numberGenerator.GetBytes(randomBytes);

            return Convert.ToBase64String(randomBytes);
        }

        public bool VerifyHash(string password, string hash, string salt)
        {
            var createHashThenGetHash = CreateHash(password, salt).Split('æ')[0];
            return createHashThenGetHash == hash;
        }
    }
}
