using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

public static class FloodEx
{
    static string plaintext = null;
    private static byte[] cipherText;

    public static string Decrypt(string Text)
    {

        plaintext = null;
        cipherText = Convert.FromBase64String(Text.Replace(' ', '+'));
        
            

        return plaintext;
    }
}

