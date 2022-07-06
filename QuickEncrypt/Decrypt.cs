using System.Runtime.InteropServices;
using System.Security.Authentication;
using System.Security.Cryptography;

namespace QuickEncrypt;

public class Decrypt
{
    public static byte[] DecryptAes(byte[] iv, byte[] key, byte[] encrypted, PaddingMode padding, CipherMode mode)
    {
        Aes aes = Aes.Create();

        aes.Key = key;
        aes.IV = iv;
        aes.Mode = mode;
        aes.Padding = padding;

        switch (mode)
        {
            case CipherMode.CBC: return aes.DecryptCbc(encrypted, iv, padding);
            case CipherMode.ECB: return aes.DecryptEcb(encrypted, padding);
            case CipherMode.CFB: return aes.DecryptCfb(encrypted, iv, padding);

            default: return Array.Empty<byte>();
        }
    }

    public static byte[] DecryptDes(byte[] iv, byte[] key, byte[] encrypted, PaddingMode padding, CipherMode mode)
    {
        DES des = DES.Create();

        des.Key = key;
        des.IV = iv;
        des.Mode = mode;
        des.Padding = padding;

        switch (mode)
        {
            case CipherMode.CBC: return des.DecryptCbc(encrypted, iv, padding);
            case CipherMode.ECB: return des.DecryptEcb(encrypted, padding);
            case CipherMode.CFB: return des.DecryptCfb(encrypted, iv, padding);

            default: return Array.Empty<byte>();
        }
    }

    public static byte[] DecryptRc2(byte[] iv, byte[] key, byte[] encrypted, PaddingMode padding, CipherMode mode)
    {
        RC2 rc2 = RC2.Create();

        rc2.Key = key;
        rc2.IV = iv;
        rc2.Mode = mode;
        rc2.Padding = padding;

        switch (mode)
        {
            case CipherMode.CBC: return rc2.DecryptCbc(encrypted, iv, padding);
            case CipherMode.ECB: return rc2.DecryptEcb(encrypted, padding);
            case CipherMode.CFB: return rc2.DecryptCfb(encrypted, iv, padding);

            default: return Array.Empty<byte>();
        }
    }

    public static byte[] DecryptTripleDes(byte[] iv, byte[] key, byte[] encrypted, PaddingMode padding, CipherMode mode)
    {
        TripleDES des = TripleDES.Create();

        des.Key = key;
        des.IV = iv;
        des.Mode = mode;
        des.Padding = padding;

        switch (mode)
        {
            case CipherMode.CBC: return des.DecryptCbc(encrypted, iv, padding);
            case CipherMode.ECB: return des.DecryptEcb(encrypted, padding);
            case CipherMode.CFB: return des.DecryptCfb(encrypted, iv, padding);

            default: return Array.Empty<byte>();
        }
    }
}