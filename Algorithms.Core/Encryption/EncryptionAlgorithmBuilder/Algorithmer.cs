namespace Algorithms.Core.Encryption.EncryptionAlgorithmBuilder
{
    public class Algorithmer
    {
        public EncriptionAlgorithmBuilder Encrypt(EncriptionAlgorithmBuilder encryptionAlgorithmBuilder,string message)
        {
            encryptionAlgorithmBuilder.CreateEncriptionAlgorithm(message);
       //     encryptionAlgorithmBuilder.SetPassword(password);
            return encryptionAlgorithmBuilder;   
        }
        //public string Decrypt(EncriptionAlgorithmBuilder encryptionAlgorithmBuilder, string message, string password="")
        //{
        //    encryptionAlgorithmBuilder.CreateEncriptionAlgorithm(message);
        //    encryptionAlgorithmBuilder.SetPassword(password);
        //    return encryptionAlgorithmBuilder.Decrypt();
        //}
    }
}
