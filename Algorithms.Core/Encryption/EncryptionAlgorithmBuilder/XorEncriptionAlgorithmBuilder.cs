using Algorithms.Core.Encryption.EncryptionAlgorithmBuilder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Core.Encryption.EncryptionAlgorithmBuilder
{
    public class XorEncriptionAlgorithmBuilder : EncriptionAlgorithmBuilder
    {
        private string GetRepeatKey(string s, int n)
        {
            var r = s;
            while (r.Length < n)
            {
                r += r;
            }

            return r.Substring(0, n);
        }

        private string Cipher(string text, string secretKey)
        {
            var currentKey = GetRepeatKey(secretKey, text.Length);
            var res = string.Empty;
            for (var i = 0; i < text.Length; i++)
            {
                res += ((char)(text[i] ^ currentKey[i])).ToString();
            }

            return res;
        }

        public override void SetPassword(string password)
        {
            this.EncryptionAlgorithm.Password = password;
        }

        public override string Encrypt()
        {
            return Cipher(this.EncryptionAlgorithm.Message, this.EncryptionAlgorithm.Password);
        }

        public override string Decrypt()
        {
            return Cipher(this.EncryptionAlgorithm.Message, this.EncryptionAlgorithm.Password);
        }
    }
}
