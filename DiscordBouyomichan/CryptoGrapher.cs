using System;
using System.Text;
using System.Security.Cryptography;

namespace DiscordBouyomichan
{
    class CryptoGrapher
    {
        private static string AesIV = "+~QVH~DK)Ku8t#Nv";
        private static string AesKey = System.Security.Principal.WindowsIdentity.GetCurrent().User.ToString();
        private static AesCryptoServiceProvider aes = new AesCryptoServiceProvider();
        static CryptoGrapher()
        {
            aes.BlockSize = 128;
            aes.KeySize =128;
            aes.IV = Encoding.UTF8.GetBytes(AesIV);
            aes.Key = Encoding.UTF8.GetBytes(AesKey.Substring(0,16));
            aes.Mode = CipherMode.CBC;
            aes.Padding = PaddingMode.PKCS7;
        }

        public static string Encrypt(string text)
        {

            byte[] src = Encoding.Unicode.GetBytes(text);

            using (ICryptoTransform encrypt = aes.CreateEncryptor())
            {
                byte[] dest = encrypt.TransformFinalBlock(src, 0, src.Length);
                return Convert.ToBase64String(dest);
            }
        }

        public static string Decrypt(string text)
        {
            try {
                byte[] src = Convert.FromBase64String(text);

                using (ICryptoTransform decrypt = aes.CreateDecryptor())
                {
                    byte[] dest = decrypt.TransformFinalBlock(src, 0, src.Length);
                    return Encoding.Unicode.GetString(dest);
                }
            }
            catch
            {
                return "";
            }
        }
    }
}
