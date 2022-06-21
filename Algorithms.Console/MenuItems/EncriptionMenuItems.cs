using Algorithms.Core.Encryption;
//using Algorithms.Core.Encryption.Atbash;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.ConsoleApp.MenuItems
{
    internal class EncriptionMenuItems : IMenuItem
    {
        public static readonly Lazy<List<IEncryptionAlgorithm>> EncryptionAlgorithms = new Lazy<List<IEncryptionAlgorithm>>(GetEncryptionAlgorithms);

        public string Name => "Encryption Algorithms";

        private static List<IEncryptionAlgorithm> GetEncryptionAlgorithms()
        {
            List<IEncryptionAlgorithm> algorithms = new List<IEncryptionAlgorithm>
            {
             //   new Atbash()
            };
            return algorithms;
        }
    }
}
