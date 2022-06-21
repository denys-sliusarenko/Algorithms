namespace Algorithms.Core.Encryption.EncryptionAlgorithmBuilder
{
    public class Algorithmer
    {
        public string Encrypt(EncriptionAlgorithmBuilder encryptionAlgorithmBuilder,string message)
        {
            encryptionAlgorithmBuilder.CreateEncriptionAlgorithm(message);
            encryptionAlgorithmBuilder.SetPassword();
            return encryptionAlgorithmBuilder.Encrypt();   
        }
        public string Decrypt(EncriptionAlgorithmBuilder encryptionAlgorithmBuilder, string message)
        {
            encryptionAlgorithmBuilder.CreateEncriptionAlgorithm(message);
            encryptionAlgorithmBuilder.SetPassword();
            return encryptionAlgorithmBuilder.Decrypt();
        }
    }
}
