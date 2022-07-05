using System.Security.Cryptography;
using System.Text;
using PowerArgs;
using Spectre.Console;

namespace QuickEncrypt;

[ArgExceptionBehavior(ArgExceptionPolicy.StandardExceptionHandling)]
public class EncryptMethods
{
    private readonly TextPrompt<byte[]> _keyPrompt = new TextPrompt<byte[]>("Enter the Encryption Key").Secret();
    private readonly TextPrompt<byte[]> _ivPrompt = new TextPrompt<byte[]>("Enter the Initialization Vector");

    // Aes Methods Start
    [ArgActionMethod]
    public void EncryptAesCbc(EncryptArgs args)
    {
        byte[] plain = File.ReadAllBytes(args.FileName);
        byte[] key = AnsiConsole.Prompt(_keyPrompt);
        byte[] iv = AnsiConsole.Prompt(_ivPrompt);

        File.WriteAllBytes(args.OutFile, Encrypt.EncryptAesCbc(iv, key, plain));
    }

    [ArgActionMethod]
    public void EncryptAesEcb(EncryptArgs args)
    {
        byte[] plain = File.ReadAllBytes(args.FileName);
        byte[] key = AnsiConsole.Prompt(_keyPrompt);
        byte[] iv = AnsiConsole.Prompt(_ivPrompt);

        File.WriteAllBytes(args.OutFile, Encrypt.EncryptAesEcb(iv, key, plain));
    }

    [ArgActionMethod]
    public void EncryptAesCfb(EncryptArgs args)
    {
        byte[] plain = File.ReadAllBytes(args.FileName);
        byte[] key = AnsiConsole.Prompt(_keyPrompt);
        byte[] iv = AnsiConsole.Prompt(_ivPrompt);

        File.WriteAllBytes(args.OutFile, Encrypt.EncryptAesCfb(iv, key, plain));
    }

    [ArgActionMethod]
    public void DecryptAesCbc(EncryptArgs args)
    {
        byte[] enc = File.ReadAllBytes(args.FileName);
        byte[] key = AnsiConsole.Prompt(_keyPrompt);
        byte[] iv = AnsiConsole.Prompt(_ivPrompt);

        File.WriteAllBytes(args.OutFile, Decrypt.DecryptAesCbc(iv, key, enc));
    }

    [ArgActionMethod]
    public void DecryptAesEcb(EncryptArgs args)
    {
        byte[] enc = File.ReadAllBytes(args.FileName);
        byte[] key = AnsiConsole.Prompt(_keyPrompt);
        byte[] iv = AnsiConsole.Prompt(_ivPrompt);

        File.WriteAllBytes(args.OutFile, Decrypt.DecryptAesEcb(iv, key, enc));
    }

    [ArgActionMethod]
    public void DecryptAesCfb(EncryptArgs args)
    {
        byte[] enc = File.ReadAllBytes(args.FileName);
        byte[] key = AnsiConsole.Prompt(_keyPrompt);
        byte[] iv = AnsiConsole.Prompt(_ivPrompt);

        File.WriteAllBytes(args.OutFile, Decrypt.DecryptAesCfb(iv, key, enc));
    }

    // Aes Methods End
    // Des Methods Start
    [ArgActionMethod]
    public void EncryptDesCbc(EncryptArgs args)
    {
        byte[] plain = File.ReadAllBytes(args.FileName);
        byte[] key = AnsiConsole.Prompt(_keyPrompt);
        byte[] iv = AnsiConsole.Prompt(_ivPrompt);

        File.WriteAllBytes(args.OutFile, Encrypt.EncryptDesCbc(iv, key, plain));
    }

    [ArgActionMethod]
    public void EncryptDesEcb(EncryptArgs args)
    {
        byte[] plain = File.ReadAllBytes(args.FileName);
        byte[] key = AnsiConsole.Prompt(_keyPrompt);
        byte[] iv = AnsiConsole.Prompt(_ivPrompt);

        File.WriteAllBytes(args.OutFile, Encrypt.EncryptDesEcb(iv, key, plain));
    }

    [ArgActionMethod]
    public void EncryptDesCfb(EncryptArgs args)
    {
        byte[] plain = File.ReadAllBytes(args.FileName);
        byte[] key = AnsiConsole.Prompt(_keyPrompt);
        byte[] iv = AnsiConsole.Prompt(_ivPrompt);

        File.WriteAllBytes(args.OutFile, Encrypt.EncryptDesCfb(iv, key, plain));
    }

    [ArgActionMethod]
    public void DecryptDesCbc(EncryptArgs args)
    {
        byte[] enc = File.ReadAllBytes(args.FileName);
        byte[] key = AnsiConsole.Prompt(_keyPrompt);
        byte[] iv = AnsiConsole.Prompt(_ivPrompt);

        File.WriteAllBytes(args.OutFile, Decrypt.DecryptDesCbc(iv, key, enc));
    }

    [ArgActionMethod]
    public void DecryptDesEcb(EncryptArgs args)
    {
        byte[] enc = File.ReadAllBytes(args.FileName);
        byte[] key = AnsiConsole.Prompt(_keyPrompt);
        byte[] iv = AnsiConsole.Prompt(_ivPrompt);

        File.WriteAllBytes(args.OutFile, Decrypt.DecryptDesCfb(iv, key, enc));
    }

    [ArgActionMethod]
    public void DecryptDesCfb(EncryptArgs args)
    {
        byte[] enc = File.ReadAllBytes(args.FileName);
        byte[] key = AnsiConsole.Prompt(_keyPrompt);
        byte[] iv = AnsiConsole.Prompt(_ivPrompt);

        File.WriteAllBytes(args.OutFile, Decrypt.DecryptDesCfb(iv, key, enc));
    }

    [ArgActionMethod]
    public void Md5([ArgRequired][ArgDescription("The filename to be hashed")][ArgExistingFile] string filename)
    {
        Console.WriteLine(BitConverter.ToString(Hash.GetMd5(filename)).Replace("-", string.Empty));
    }

    [ArgActionMethod]
    public void Sha1([ArgRequired] [ArgDescription("The filename to be hashed")] [ArgExistingFile] string filename)
    {
        Console.WriteLine(BitConverter.ToString(Hash.GetSha1(filename)).Replace("-", string.Empty));
    }

    [ArgActionMethod]
    public void Sha256([ArgRequired][ArgDescription("The filename to be hashed")][ArgExistingFile] string filename)
    {
        Console.WriteLine(BitConverter.ToString(Hash.GetSha256(filename)).Replace("-", string.Empty));
    }
    [ArgActionMethod]
    public void Sha384([ArgRequired][ArgDescription("The filename to be hashed")][ArgExistingFile] string filename)
    {
        Console.WriteLine(BitConverter.ToString(Hash.GetSha384(filename)).Replace("-", string.Empty));
    }

    [ArgActionMethod]
    public void Sha512([ArgRequired][ArgDescription("The filename to be hashed")][ArgExistingFile] string filename)
    {
        Console.WriteLine(BitConverter.ToString(Hash.GetSha512(filename)).Replace("-", string.Empty));
    }
}

class Program
{
    public static void Main(string[] args)
    {
        Args.InvokeAction<EncryptMethods>(args);
    }
}