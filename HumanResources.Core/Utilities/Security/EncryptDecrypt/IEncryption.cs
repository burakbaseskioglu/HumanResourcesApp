using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResources.Core.Utilities.Security.EncryptDecrypt
{
    public interface IEncryption
    {
        string EncryptText(string input, string privateKey = null);
        string DecryptText(string input, string privateKey = null);
    }
}
