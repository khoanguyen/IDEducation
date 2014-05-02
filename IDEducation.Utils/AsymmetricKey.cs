using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDEducation.Utils
{
    public class AsymmetricKey
    {
        public string PublicKey { get; private set; }
        public string PrivateKey { get; private set; }

        public AsymmetricKey(string publicKey, string privateKey) {
            PublicKey = publicKey;
            PrivateKey = privateKey;
        }
    }
}
