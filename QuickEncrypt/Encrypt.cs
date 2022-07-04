using System.Security.Cryptography;
using Spectre.Console;

namespace QuickEncrypt;

public class Encrypt
{
    public static byte[] EncryptAesCbc(byte[] iv, byte[] key, byte[] plain)
    {
        Aes aes = Aes.Create();

        aes.Key = key;
        aes.IV = iv;
        aes.Mode = CipherMode.CBC;

        return aes.EncryptCbc(plain, iv);
    }

    public static byte[] EncryptAesEcb(byte[] iv, byte[] key, byte[] plain)
    {
        Aes aes = Aes.Create();

        aes.Key = key;
        aes.IV = iv;
        aes.Mode = CipherMode.ECB;

        return aes.EncryptEcb(plain, PaddingMode.None);
    }

    public static byte[] EncryptAesCfb(byte[] iv, byte[] key, byte[] plain)
    {
        Aes aes = Aes.Create();

        aes.Key = key;
        aes.IV = iv;
        aes.Mode = CipherMode.ECB;

        return aes.EncryptCfb(plain, iv);
    }
}