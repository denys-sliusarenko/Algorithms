namespace Algorithms.Core.Encryption.EncryptionAlgorithmBuilder
{
    public abstract class EncriptionAlgorithmBuilder
    {
        public EncryptionAlgorithm EncryptionAlgorithm { get; private set; }
        public void CreateEncriptionAlgorithm(string message)
        {
            EncryptionAlgorithm = new EncryptionAlgorithm(message);
        }
        public abstract void SetPassword();
        public abstract string Encrypt();
        public abstract string Decrypt();
    }
}
