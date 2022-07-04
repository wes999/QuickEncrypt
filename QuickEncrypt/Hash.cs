using System.Security.Cryptography;

namespace QuickEncrypt;

public static class Hash
{
    public static byte[] GetMd5(string filename)
    {
        MD5 md5 = MD5.Create();

        return md5.ComputeHash(new FileStream(filename, FileMode.Open));
    }

    public static byte[] GetSha256(string filename)
    {
        SHA256 sha256 = SHA256.Create();

        return sha256.ComputeHash(new FileStream(filename, FileMode.Open));
    }
}