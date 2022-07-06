using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace QuickEncrypt;

public class Decrypt
{
    public static byte[] DecryptAesCbc(byte[] iv, byte[] key, byte[] encrypted)
    {
        Aes aes = Aes.Create();

        aes.Key = key;
        aes.IV = iv;
        aes.Mode = CipherMode.CBC;

        return aes.DecryptCbc(encrypted, iv);
    }

    public static byte[] DecryptAesEcb(byte[] iv, byte[] key, byte[] encrypted)
    {
        Aes aes = Aes.Create();

        aes.Key = key;
        aes.IV = iv;
        aes.Mode = CipherMode.CBC;

        return aes.DecryptEcb(encrypted, PaddingMode.None);
    }

    public static byte[] DecryptAesCfb(byte[] iv, byte[] key, byte[] encrypted)
    {
        Aes aes = Aes.Create();

        aes.Key = key;
        aes.IV = iv;
        aes.Mode = CipherMode.CBC;

        return aes.DecryptCfb(encrypted, iv);
    }

    public static byte[] DecryptDesCbc(byte[] iv, byte[] key, byte[] encrypted)
    {
        DES des = DES.Create();

        des.Key = key;
        des.IV = iv;
        des.Mode = CipherMode.CBC;

        return des.DecryptCbc(encrypted, iv);
    }

    public static byte[] DecryptDesEcb(byte[] iv, byte[] key, byte[] encrypted)
    {
        DES des = DES.Create();

        des.Key = key;
        des.IV = iv;
        des.Mode = CipherMode.ECB;

        return des.DecryptEcb(encrypted, PaddingMode.None);
    }

    public static byte[] DecryptDesCfb(byte[] iv, byte[] key, byte[] encrypted)
    {
        DES des = DES.Create();

        des.Key = key;
        des.IV = iv;
        des.Mode = CipherMode.CFB;

        return des.DecryptCfb(encrypted, iv);
    }

    public static byte[] DecryptRc2Cbc(byte[] iv, byte[] key, byte[] encrypted)
    {

    }
}