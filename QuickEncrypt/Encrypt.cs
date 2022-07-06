using System.Security.Cryptography;
using Spectre.Console;

namespace QuickEncrypt;

public class Encrypt
{
    public static byte[] EncryptAesCbc(byte[] iv, byte[] key, byte[] plain, PaddingMode padding)
    {
        Aes aes = Aes.Create();

        aes.Key = key;
        aes.IV = iv;
        aes.Mode = CipherMode.CBC;
        aes.Padding = padding;

        return aes.EncryptCbc(plain, iv, padding);
    }

    public static byte[] EncryptAesEcb(byte[] iv, byte[] key, byte[] plain, PaddingMode mode)
    {
        Aes aes = Aes.Create();

        aes.Key = key;
        aes.IV = iv;
        aes.Mode = CipherMode.ECB;
        aes.Padding = mode;

        return aes.EncryptEcb(plain, mode);
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

    public static byte[] EncryptRc2Cbc(byte[] iv, byte[] key, byte[] plain)
    {
        RC2 rc2 = RC2.Create();

        rc2.Key = key;
        rc2.IV = iv;
        rc2.Mode = CipherMode.CBC;

        return rc2.EncryptCbc(plain, iv);
    }

    public static byte[] EncryptRc2Ecb(byte[] iv, byte[] key, byte[] plain)
    {
        RC2 rc2 = RC2.Create();

        rc2.Key = key;
        rc2.IV = iv;
        rc2.Mode = CipherMode.ECB;

        return rc2.EncryptEcb(plain, PaddingMode.None);
    }

    public static byte[] EncryptRc2Cfb(byte[] iv, byte[] key, byte[] plain)
    {
        RC2 rc2 = RC2.Create();

        rc2.Key = key;
        rc2.IV = iv;
        rc2.Mode = CipherMode.ECB;

        return rc2.EncryptCfb(plain, iv);
    }
}