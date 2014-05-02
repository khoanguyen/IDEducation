using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace IDEducation.Utils
{
    public static class KeyUtils
    {
        public static AsymmetricKey GenerateDSA(int keySize = 2048, string containerName = null)
        {
            CspParameters cspParam = null;
            if (!string.IsNullOrWhiteSpace(containerName))
            {
                cspParam = new CspParameters
                {
                    KeyContainerName = containerName,
                };
            }

            var provider = cspParam == null ?
                new DSACryptoServiceProvider(keySize) :
                new DSACryptoServiceProvider(keySize, cspParam);

            var privateKeyParameter = provider.ToXmlString(true);
            var publicKeyParameter = provider.ToXmlString(false);

            return new AsymmetricKey(publicKeyParameter, privateKeyParameter);
        }

        public static void PersistKey(string fileName)
        {
            var publicKeyFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName + ".public");
        }
    }
}
