namespace Algorithms.Core.Encryption.EncryptionAlgorithmBuilder
{
    public class AtbashEncriptionAlgorithmBuilder : EncriptionAlgorithmBuilder
    {
        private const string alphabet = "abcdefghijklmnopqrstuvwxyz ";

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

        public override string Encrypt()
        {
            return EncryptDecrypt(this.EncryptionAlgorithm.Message, alphabet, Reverse(alphabet));
        }

        public override string Decrypt()
        {
            return EncryptDecrypt(this.EncryptionAlgorithm.Message, Reverse(alphabet), alphabet);
        }

        public override void SetPassword(string password)
        {
            //not use
        }
    }
}
