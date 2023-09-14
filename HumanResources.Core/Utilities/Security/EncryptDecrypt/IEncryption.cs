namespace HumanResources.Core.Utilities.Security.EncryptDecrypt
{
    public interface IEncryption
    {
        string EncryptText(string plainText, string key);
        string DecryptText(string encryptedText, string key);
        string GenerateKey();
    }
}
