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

    public static byte[] EncryptDesCbc(byte[] iv, byte[] key, byte[] plain)
    {
        DES des = DES.Create();

        des.Key = key;
        des.IV = iv;
        des.Mode = CipherMode.CBC;

        return des.EncryptCbc(plain, iv);
    }

    public static byte[] EncryptDesEcb(byte[] iv, byte[] key, byte[] plain)
    {
        DES des = DES.Create();

        des.Key = key;
        des.IV = iv;
        des.Mode = CipherMode.ECB;

        return des.EncryptEcb(plain, PaddingMode.None);
    }

    public static byte[] EncryptDesCfb(byte[] iv, byte[] key, byte[] plain)
    {
        DES des = DES.Create();

        des.Key = key;
        des.IV = iv;
        des.Mode = CipherMode.CFB;

        return des.EncryptCfb(plain, iv);
    }
}