namespace Algorithms.Core.Encryption.EncryptionAlgorithmBuilder
{
    public class Algorithmer
    {
        public string Encrypt(EncriptionAlgorithmBuilder encryptionAlgorithmBuilder,string message,string password="")
        {
            encryptionAlgorithmBuilder.CreateEncriptionAlgorithm(message);
            encryptionAlgorithmBuilder.SetPassword(password);
            return encryptionAlgorithmBuilder.Encrypt();   
        }
        public string Decrypt(EncriptionAlgorithmBuilder encryptionAlgorithmBuilder, string message, string password="")
        {
            encryptionAlgorithmBuilder.CreateEncriptionAlgorithm(message);
            encryptionAlgorithmBuilder.SetPassword(password);
            return encryptionAlgorithmBuilder.Decrypt();
        }
    }
}
