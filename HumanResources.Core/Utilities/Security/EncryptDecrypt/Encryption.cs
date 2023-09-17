using System.Security.Cryptography;
using System.Text;

namespace HumanResources.Core.Utilities.Security.EncryptDecrypt
{
    public class Encryption : IEncryption
    {
        public string DecryptText(string encryptedText, string key)
        {
            string plainText = string.Empty;

            using (Aes aes = Aes.Create())
            {
                var encryptedTextStringToByte = Convert.FromBase64String(encryptedText);
                aes.Key = Encoding.ASCII.GetBytes(key.Substring(0, 32));
                aes.IV = Encoding.ASCII.GetBytes(key.Substring(16, 16));

                ICryptoTransform cryptoTransform = aes.CreateDecryptor(aes.Key, aes.IV);

                using (MemoryStream memoryStream = new MemoryStream(encryptedTextStringToByte))
                {
                    using (CryptoStream cryptoStream = new CryptoStream(memoryStream, cryptoTransform, CryptoStreamMode.Read))
                    {
                        using (StreamReader streamReader = new StreamReader(cryptoStream))
                        {
                            plainText = streamReader.ReadToEnd();
                        }
                    }
                }
            }

            return plainText;
        }

        public string EncryptText(string plainText, string key)
        {
            byte[] encryptedBytes;
            using (Aes aes = Aes.Create())
            {
                var keyStringToByte = Convert.FromBase64String(key);
                aes.Key = Encoding.ASCII.GetBytes(key.Substring(0, 32));
                aes.IV = Encoding.ASCII.GetBytes(key.Substring(16, 16));

                ICryptoTransform cryptoTransform = aes.CreateEncryptor(aes.Key, aes.IV);

                using (MemoryStream memoryStream = new MemoryStream())
                {
                    using (CryptoStream cryptoStream = new CryptoStream(memoryStream, cryptoTransform, CryptoStreamMode.Write))
                    {
                        using (StreamWriter streamWriter = new StreamWriter(cryptoStream))
                        {
                            streamWriter.Write(plainText);
                        }
                        encryptedBytes = memoryStream.ToArray();
                    }
                }
            }

            return Convert.ToBase64String(encryptedBytes);
        }

        public string GenerateKey()
        {
            using (RandomNumberGenerator randomNumberGenerator = RandomNumberGenerator.Create())
            {
                byte[] randomBytes = new byte[32];
                randomNumberGenerator.GetBytes(randomBytes);
                return Convert.ToBase64String(randomBytes);
            }
        }
    }
}
