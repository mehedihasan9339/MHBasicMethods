using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace MHBasicMethods
{
    public class MHEncryption
    {
        public string Encrypt(string plainText, string secretKey)
        {
            using (Aes aesAlg = Aes.Create())
            {
                byte[] key = DeriveKey(secretKey, aesAlg.KeySize / 8);
                aesAlg.Key = key;
                aesAlg.IV = new byte[aesAlg.BlockSize / 8];

                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            swEncrypt.Write(plainText);
                        }
                    }
                    return Convert.ToBase64String(msEncrypt.ToArray());
                }
            }
        }

        public string Decrypt(string cipherText, string secretKey)
        {
            using (Aes aesAlg = Aes.Create())
            {
                byte[] key = DeriveKey(secretKey, aesAlg.KeySize / 8);
                aesAlg.Key = key;
                aesAlg.IV = new byte[aesAlg.BlockSize / 8];

                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                using (MemoryStream msDecrypt = new MemoryStream(Convert.FromBase64String(cipherText)))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {
                            return srDecrypt.ReadToEnd();
                        }
                    }
                }
            }
        }


        private static byte[] DeriveKey(string userProvidedKey, int keySize)
        {
            using (Rfc2898DeriveBytes deriveBytes = new Rfc2898DeriveBytes(userProvidedKey, new byte[8], 1000))
            {
                return deriveBytes.GetBytes(keySize);
            }
        }








    }
}
