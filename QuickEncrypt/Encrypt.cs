using System.Security.Cryptography;
using Spectre.Console;

namespace QuickEncrypt;

public class Encrypt
{
    public static byte[] EncryptAes(byte[] iv, byte[] key, byte[] plain, PaddingMode padding, CipherMode mode)
    {
        Aes aes = Aes.Create();

        aes.Key = key;
        aes.IV = iv;
        aes.Mode = mode;
        aes.Padding = padding;

        switch (mode)
        {
            case CipherMode.CBC: return aes.EncryptCbc(plain, iv, padding); 
            case CipherMode.ECB: return aes.EncryptEcb(plain, padding); 
            case CipherMode.CFB: return aes.EncryptCfb(plain, iv, padding);

            default: return Array.Empty<byte>();
        }
    }

    public static byte[] EncryptDes(byte[] iv, byte[] key, byte[] plain, PaddingMode padding, CipherMode mode)
    {
        DES des = DES.Create();

        des.Key = key;
        des.IV = iv;
        des.Mode = mode;
        des.Padding = padding;

        switch (mode)
        {
            case CipherMode.CBC: return des.EncryptCbc(plain, iv, padding);
            case CipherMode.ECB: return des.EncryptEcb(plain, padding);
            case CipherMode.CFB: return des.EncryptCfb(plain, iv, padding);

            default: return Array.Empty<byte>(); 
        }
    }

    public static byte[] EncryptRc2(byte[] iv, byte[] key, byte[] plain, PaddingMode padding, CipherMode mode)
    {
        RC2 rc2 = RC2.Create();

        rc2.Key = key;
        rc2.IV = iv;
        rc2.Mode = mode;
        rc2.Padding = padding;

        switch (mode)
        {
            case CipherMode.CBC: return rc2.EncryptCbc(plain, iv, padding);
            case CipherMode.ECB: return rc2.EncryptEcb(plain, padding);
            case CipherMode.CFB: return rc2.EncryptCfb(plain, iv, padding);

            default: return Array.Empty<byte>();
        }
    }

    public static byte[] EncryptTripleDes(byte[] iv, byte[] key, byte[] plain, PaddingMode padding, CipherMode mode)
    {
        TripleDES des = TripleDES.Create();

        des.Key = key;
        des.IV = iv;
        des.Mode = mode;
        des.Padding = padding;

        switch (mode)
        {
            case CipherMode.CBC: return des.EncryptCbc(plain, iv, padding);
            case CipherMode.ECB: return des.EncryptEcb(plain, padding);
            case CipherMode.CFB: return des.EncryptCfb(plain, iv, padding);

            default: return Array.Empty<byte>();
        }
    }
}