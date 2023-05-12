using System;
using System.Diagnostics;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Utils.Common.Encryption
{
    public class EncryptionService : IEncryptionService
    {
        public string GenerateEncryptionKey()
        {
            using var rijndael = new AesCryptoServiceProvider
            {
                Padding = PaddingMode.PKCS7
            };
            rijndael.GenerateIV();
            rijndael.GenerateKey();
            return $"{Convert.ToBase64String(rijndael.Key)};{Convert.ToBase64String(rijndael.IV)}";
        }
        public string Encrypt(string key, string data)
        {
            var split = key.Split(';');
            using var myRijndael = new AesCryptoServiceProvider
            {
                Padding = PaddingMode.PKCS7,
                Key = Convert.FromBase64String(split[0]),
                IV = Convert.FromBase64String(split[1])
            };

            using var encryptor = myRijndael.CreateEncryptor();
            using var msEncrypt = new MemoryStream();
            using var csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write);
            csEncrypt.Write(Encoding.UTF8.GetBytes(data));
            csEncrypt.Flush();
            csEncrypt.FlushFinalBlock();
            var ret = Convert.ToBase64String(msEncrypt.ToArray());
#if DEBUG
            Debug.Assert(data != Encoding.UTF8.GetString(msEncrypt.ToArray()), "Data was not encrypted");
            Debug.Assert(data == Decrypt(key, ret), "Decrypted data is different from encrypted data");
#endif
            return ret;
        }

        public string Decrypt(string key, string data)
        {
            var split = key.Split(';');
            using var myRijndael = new AesCryptoServiceProvider
            {
                Padding = PaddingMode.PKCS7,
                Key = Convert.FromBase64String(split[0]),
                IV = Convert.FromBase64String(split[1])
            };

            using var decryptor = myRijndael.CreateDecryptor();
            using var msDecrypt = new MemoryStream();
            using var csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Write);
            csDecrypt.Write(Convert.FromBase64String(data));
            csDecrypt.Flush();
            csDecrypt.FlushFinalBlock();
            return Encoding.UTF8.GetString(msDecrypt.ToArray());
        }
    }
}