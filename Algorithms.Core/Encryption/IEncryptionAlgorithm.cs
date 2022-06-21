using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Core.Encryption
{
    public interface IEncryptionAlgorithm
    {
        string Name { get; }
        string Encrypt(string plainText);
        string Decrypt(string encryptedText);
    }
}
