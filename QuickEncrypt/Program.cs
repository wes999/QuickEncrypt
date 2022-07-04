using System.Text;
using PowerArgs;

namespace QuickEncrypt;

[ArgExceptionBehavior(ArgExceptionPolicy.StandardExceptionHandling)]
public class EncryptMethods
{
    [ArgActionMethod]
    public void EncryptAesCbc(EncryptArgs args)
    {
        byte[] plain = File.ReadAllBytes(args.FileName);
        byte[] key = Encoding.ASCII.GetBytes(args.Key);
        byte[] iv = Encoding.ASCII.GetBytes(args.Iv);

        File.WriteAllBytes(args.OutFile, Encrypt.EncryptAesCbc(iv, key, plain));
    }

    [ArgActionMethod]
    public void EncryptAesEcb(EncryptArgs args)
    {
        byte[] plain = File.ReadAllBytes(args.FileName);
        byte[] key = Encoding.ASCII.GetBytes(args.Key);
        byte[] iv = Encoding.ASCII.GetBytes(args.Iv);

        File.WriteAllBytes(args.OutFile, Encrypt.EncryptAesEcb(iv, key, plain));
    }

    [ArgActionMethod]
    public void EncryptAesCfb(EncryptArgs args)
    {
        byte[] plain = File.ReadAllBytes(args.FileName);
        byte[] key = Encoding.ASCII.GetBytes(args.Key);
        byte[] iv = Encoding.ASCII.GetBytes(args.Iv);

        File.WriteAllBytes(args.OutFile, Encrypt.EncryptAesCfb(iv, key, plain));
    }

    [ArgActionMethod]
    public void DecryptAesCbc(EncryptArgs args)
    {
        byte[] enc = File.ReadAllBytes(args.FileName);
        byte[] key = Encoding.ASCII.GetBytes(args.Key);
        byte[] iv = Encoding.ASCII.GetBytes(args.Iv);

        File.WriteAllBytes(args.OutFile, Decrypt.DecryptAesCbc(iv, key, enc));
    }

    [ArgActionMethod]
    public void DecryptAesEcb(EncryptArgs args)
    {
        byte[] enc = File.ReadAllBytes(args.FileName);
        byte[] key = Encoding.ASCII.GetBytes(args.Key);
        byte[] iv = Encoding.ASCII.GetBytes(args.Iv);

        File.WriteAllBytes(args.OutFile, Decrypt.DecryptAesEcb(iv, key, enc));
    }

    [ArgActionMethod]
    public void DecryptAesCfb(EncryptArgs args)
    {
        byte[] enc = File.ReadAllBytes(args.FileName);
        byte[] key = Encoding.ASCII.GetBytes(args.Key);
        byte[] iv = Encoding.ASCII.GetBytes(args.Iv);

        File.WriteAllBytes(args.OutFile, Decrypt.DecryptAesCfb(iv, key, enc));
    }

    [ArgActionMethod]
    public void Md5(string filename)
    {
        Console.WriteLine(BitConverter.ToString(Hash.GetMd5(filename)).Replace("-", string.Empty));
    }

    [ArgActionMethod]
    public void Sha256(string filename)
    {
        Console.WriteLine(BitConverter.ToString(Hash.GetSha256(filename)).Replace("-", string.Empty));
    }
}

class Program
{
    public static void Main(string[] args)
    {
        Args.InvokeAction<EncryptMethods>(args);
    }
}