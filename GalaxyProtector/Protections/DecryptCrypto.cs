using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

public static class DecryptCrypto
{
    private static byte[] Key = Encoding.ASCII.GetBytes(@"qwr{@^h`h&_`50/.a9!'dcmh3!uw<&=?");
    private static byte[] IV = Encoding.ASCII.GetBytes(@"9/\~V).A.lY&=t2b");
    //static AesCryptoServiceProvider aesAlg2 = new AesCryptoServiceProvider();
    static string plaintext = null;
    private static byte[] cipherText;
    //private static ICryptoTransform decryptor;
    //private static MemoryStream msDecrypt;
    //private static CryptoStream csDecrypt;
    //private static StreamReader srDecrypt;

    public static string Decrypt(string Text)
    {

        plaintext = null;
        cipherText = Convert.FromBase64String(Text.Replace(' ', '+'));

        using (AesCryptoServiceProvider aesAlg2 = new AesCryptoServiceProvider())
        {
            aesAlg2.Key = Key;
            aesAlg2.IV = IV;
            aesAlg2.Mode = CipherMode.CBC;
            aesAlg2.Padding = PaddingMode.PKCS7;


            ICryptoTransform decryptor = aesAlg2.CreateDecryptor(aesAlg2.Key, aesAlg2.IV);

            using (MemoryStream msDecrypt = new MemoryStream(cipherText))
            {
                using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                {
                    using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                    {
                        plaintext = srDecrypt.ReadToEnd();
                    }
                }
            }

        }

        return plaintext;
    }
}

