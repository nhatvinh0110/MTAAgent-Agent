using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Common.AES
{
    /// <summary>
    /// 
    /// 
    ///string data = "Some Data";

    ///string password = "enter password";

    ///string EncryptString = EncryptString_Aes(data, password);

    ///string plaintext = DecryptStringFromBytes_Aes(EncryptString, password);

    /// 
    /// </summary>
    public class AesManagedd
    {

        public string EncryptString_Aes(string plainText, string pass)
        {

            string encryptedString = null;

            byte[] key = Encoding.ASCII.GetBytes(pass).Take(16).ToArray();

            byte[] bytes = Encoding.UTF8.GetBytes(plainText);

            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Mode = CipherMode.CBC;
                aesAlg.Padding = PaddingMode.Zeros;
                aesAlg.BlockSize = 128;
                aesAlg.KeySize = 256;
                aesAlg.Key = key;

                aesAlg.IV = SHA256.Create().ComputeHash(Encoding.ASCII.GetBytes(pass)).Take(16).ToArray();

                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                byte[] encryptedData = encryptor.TransformFinalBlock(bytes, 0, bytes.Length);

                encryptedString = Convert.ToBase64String(aesAlg.IV.Concat(encryptedData).ToArray());

            }

            return encryptedString;
        }

        public string DecryptStringFromBytes_Aes(string enscriptes, string pass)
        {
            byte[] key = Encoding.ASCII.GetBytes(pass).Take(16).ToArray();

            byte[] bytes = Convert.FromBase64String(enscriptes);

            string plaintext = null;

            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Mode = CipherMode.CBC;
                aesAlg.Padding = PaddingMode.Zeros;
                aesAlg.BlockSize = 128;
                aesAlg.KeySize = 256;
                aesAlg.Key = key;

                aesAlg.IV = SHA256.Create().ComputeHash(Encoding.ASCII.GetBytes(pass)).Take(16).ToArray();

                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                plaintext = Encoding.UTF8.GetString(decryptor.TransformFinalBlock(bytes, 16, bytes.Length - 16)).Trim('0');

            }

            return plaintext;
        }

    }
}
