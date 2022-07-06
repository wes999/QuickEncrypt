using System.Security.Cryptography;
using System.Text;
using PowerArgs;
using Spectre.Console;

namespace QuickEncrypt;

[ArgExceptionBehavior(ArgExceptionPolicy.StandardExceptionHandling)]
public class EncryptMethods
{
    private readonly SelectionPrompt<PaddingMode> _paddingPrompt = new SelectionPrompt<PaddingMode>().AddChoices(Enum.GetValues<PaddingMode>());
    private readonly SelectionPrompt<CipherMode> _modePrompt = new SelectionPrompt<CipherMode>().AddChoices(Enum.GetValues<CipherMode>());

    private readonly TextPrompt<string> _keyPrompt = new TextPrompt<string>("Enter the Encryption Key").Secret();
    private readonly TextPrompt<string> _ivPrompt = new TextPrompt<string>("Enter the Initialization Vector");

    // Aes Methods Start
    [ArgActionMethod]
    public void EncryptAes(EncryptArgs args)
    {
        byte[] plain = File.ReadAllBytes(args.FileName);
        byte[] key = Encoding.ASCII.GetBytes(AnsiConsole.Prompt(_keyPrompt));
        byte[] iv = Encoding.ASCII.GetBytes(AnsiConsole.Prompt(_ivPrompt));

        CipherMode mode = AnsiConsole.Prompt(_modePrompt);
        PaddingMode padding = AnsiConsole.Prompt(_paddingPrompt);

        File.WriteAllBytes(args.OutFile, Encrypt.EncryptAes(iv, key, plain, padding, mode));
    }

    [ArgActionMethod]
    public void DecryptAes(EncryptArgs args)
    {
        byte[] enc = File.ReadAllBytes(args.FileName);
        byte[] key = Encoding.ASCII.GetBytes(AnsiConsole.Prompt(_keyPrompt));
        byte[] iv = Encoding.ASCII.GetBytes(AnsiConsole.Prompt(_ivPrompt));

        File.WriteAllBytes(args.OutFile, Decrypt.DecryptAesCbc(iv, key, enc));
    }

    // Aes Methods End
    // Des Methods Start
    [ArgActionMethod]
    public void EncryptDes(EncryptArgs args)
    {
        byte[] plain = File.ReadAllBytes(args.FileName);
        byte[] key = Encoding.ASCII.GetBytes(AnsiConsole.Prompt(_keyPrompt));
        byte[] iv = Encoding.ASCII.GetBytes(AnsiConsole.Prompt(_ivPrompt));

        CipherMode mode = AnsiConsole.Prompt(_modePrompt);
        PaddingMode padding = AnsiConsole.Prompt(_paddingPrompt);

        File.WriteAllBytes(args.OutFile, Encrypt.EncryptDes(iv, key, plain, padding, mode));
    }

    [ArgActionMethod]
    public void DecryptDes(EncryptArgs args)
    {
        byte[] enc = File.ReadAllBytes(args.FileName);
        byte[] key = Encoding.ASCII.GetBytes(AnsiConsole.Prompt(_keyPrompt));
        byte[] iv = Encoding.ASCII.GetBytes(AnsiConsole.Prompt(_ivPrompt));

        File.WriteAllBytes(args.OutFile, Decrypt.DecryptDesCbc(iv, key, enc));
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