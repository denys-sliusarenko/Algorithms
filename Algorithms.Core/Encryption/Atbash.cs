using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Core.Encryption
{
    public class Atbash: IEncryptionAlgorithm
    {
        public string Name => "Atbash encrypt";

        //alphabet
        private const string alphabet = "abcdefghijklmnopqrstuvwxyz";

        //reverse text
        private string Reverse(string inputText)
        {
            var reversedText = string.Empty;
            foreach (var s in inputText)
            {
                reversedText = s + reversedText;
            }

            return reversedText;
        }

        private string EncryptDecrypt(string text, string symbols, string cipher)
        {
            text = text.ToLower();

            var outputText = string.Empty;
            for (var i = 0; i < text.Length; i++)
            {
                var index = symbols.IndexOf(text[i]);
                if (index >= 0)
                {
                    outputText += cipher[index].ToString();
                }
            }

            return outputText;
        }

        public string Encrypt(string plainText)
        {
            return EncryptDecrypt(plainText, alphabet, Reverse(alphabet));
        }

        public string Decrypt(string encryptedText)
        {
            return EncryptDecrypt(encryptedText, Reverse(alphabet), alphabet);
        }
    }
}
