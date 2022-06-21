using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Core.Encryption.EncryptionAlgorithmBuilder
{
    public class EncryptionAlgorithm
    {
        public EncryptionAlgorithm(string message)
        {
            this.Message = message;
        }

        public string Message { get; set; }
        public string Password { get; set; }
    }
}
