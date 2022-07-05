using System.Security.Cryptography;

namespace QuickEncrypt;

public static class Hash
{
    public static byte[] GetMd5(string filename)
    {
        MD5 md5 = MD5.Create();
        
        return md5.ComputeHash(new FileStream(filename, FileMode.Open));
    }

    public static byte[] GetSha1(string filename)
    {
        SHA1 sha1 = SHA1.Create();

        return sha1.ComputeHash(new FileStream(filename, FileMode.Open));
    }

    public static byte[] GetSha256(string filename)
    {
        SHA256 sha256 = SHA256.Create();

        return sha256.ComputeHash(new FileStream(filename, FileMode.Open));
    }

    public static byte[] GetSha384(string filename)
    {
        SHA384 sha384 = SHA384.Create();

        return sha384.ComputeHash(new FileStream(filename, FileMode.Open));
    }

    public static byte[] GetSha512(string filename)
    {
        SHA512 sha512 = SHA512.Create();

        return sha512.ComputeHash(new FileStream(filename, FileMode.Open));
    }
}