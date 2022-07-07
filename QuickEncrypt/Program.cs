using System.Security.Cryptography;
using System.Text;
using PowerArgs;
using Spectre.Console;

namespace QuickEncrypt;

[ArgExceptionBehavior(ArgExceptionPolicy.StandardExceptionHandling)]
public class EncryptMethods
{
    private readonly SelectionPrompt<PaddingMode> _paddingPrompt = new SelectionPrompt<PaddingMode>().AddChoices(Enum.GetValues<PaddingMode>());
    private readonly SelectionPrompt<CipherMode> _modePrompt = new SelectionPrompt<CipherMode>().AddChoices(CipherMode.CBC, CipherMode.ECB, CipherMode.CFB);

    private readonly TextPrompt<string> _keyPrompt = new TextPrompt<string>("Encryption Key: ").PromptStyle("red").Secret();
    private readonly TextPrompt<string> _ivPrompt = new TextPrompt<string>("Enter the Initialization Vector: ").PromptStyle("red");

    // Aes Methods Start
    [ArgActionMethod, ArgDescription("Encrypt The Specified File With The Advanced Encryption Standard (AES) Algorithm")]
    public void EncryptAes(EncryptArgs args)
    {
        byte[] plain = File.ReadAllBytes(args.FileName);
        byte[] key = Encoding.ASCII.GetBytes(AnsiConsole.Prompt(_keyPrompt));
        byte[] iv = Encoding.ASCII.GetBytes(AnsiConsole.Prompt(_ivPrompt));

        CipherMode mode = AnsiConsole.Prompt(_modePrompt);
        PaddingMode padding = AnsiConsole.Prompt(_paddingPrompt);

        AnsiConsole.MarkupLine("[green4]Encrypting...[/]");
        File.WriteAllBytes(args.OutFile, Encrypt.EncryptAes(iv, key, plain, padding, mode));
    }

    [ArgActionMethod, ArgDescription("Decrypt The Specified File With The Advanced Encryption Standard (AES) Algorithm")]
    public void DecryptAes(EncryptArgs args)
    {
        byte[] enc = File.ReadAllBytes(args.FileName);
        byte[] key = Encoding.ASCII.GetBytes(AnsiConsole.Prompt(_keyPrompt));
        byte[] iv = Encoding.ASCII.GetBytes(AnsiConsole.Prompt(_ivPrompt));

        CipherMode mode = AnsiConsole.Prompt(_modePrompt);
        PaddingMode padding = AnsiConsole.Prompt(_paddingPrompt);

        AnsiConsole.MarkupLine("[green4]Encrypting...[/]");
        File.WriteAllBytes(args.OutFile, Decrypt.DecryptAes(iv, key, enc, padding, mode));
    }

    // Aes Methods End
    // Des Methods Start
    [ArgActionMethod, ArgDescription("Encrypt The Specified File With The Data Encryption Standard (DES) Algorithm")]
    public void EncryptDes(EncryptArgs args)
    {
        byte[] plain = File.ReadAllBytes(args.FileName);
        byte[] key = Encoding.ASCII.GetBytes(AnsiConsole.Prompt(_keyPrompt));
        byte[] iv = Encoding.ASCII.GetBytes(AnsiConsole.Prompt(_ivPrompt));

        CipherMode mode = AnsiConsole.Prompt(_modePrompt);
        PaddingMode padding = AnsiConsole.Prompt(_paddingPrompt);

        AnsiConsole.MarkupLine("[green4]Encrypting...[/]");
        File.WriteAllBytes(args.OutFile, Encrypt.EncryptDes(iv, key, plain, padding, mode));
    }

    [ArgActionMethod, ArgDescription("Decrypt The Specified File With The Data Encryption Standard (DES) Algorithm")]
    public void DecryptDes(EncryptArgs args)
    {
        byte[] enc = File.ReadAllBytes(args.FileName);
        byte[] key = Encoding.ASCII.GetBytes(AnsiConsole.Prompt(_keyPrompt));
        byte[] iv = Encoding.ASCII.GetBytes(AnsiConsole.Prompt(_ivPrompt));

        CipherMode mode = AnsiConsole.Prompt(_modePrompt);
        PaddingMode padding = AnsiConsole.Prompt(_paddingPrompt);

        AnsiConsole.MarkupLine("[green4]Encrypting...[/]");
        File.WriteAllBytes(args.OutFile, Decrypt.DecryptDes(iv, key, enc, padding, mode));
    }

    [ArgActionMethod, ArgDescription("Encrypt The Specified File With The Rivest Cipher 2 (RC2) Algorithm")]
    public void EncryptRc2(EncryptArgs args)
    {
        byte[] plain = File.ReadAllBytes(args.FileName);
        byte[] key = Encoding.ASCII.GetBytes(AnsiConsole.Prompt(_keyPrompt));
        byte[] iv = Encoding.ASCII.GetBytes(AnsiConsole.Prompt(_ivPrompt));

        CipherMode mode = AnsiConsole.Prompt(_modePrompt);
        PaddingMode padding = AnsiConsole.Prompt(_paddingPrompt);

        AnsiConsole.MarkupLine("[green4]Encrypting...[/]");
        File.WriteAllBytes(args.OutFile, Encrypt.EncryptRc2(iv, key, plain, padding, mode));
    }

    [ArgActionMethod, ArgDescription("Decrypt The Specified File With The Rivest Cipher 2 (RC2) Algorithm")]
    public void DecryptRc2(EncryptArgs args)
    {
        byte[] enc = File.ReadAllBytes(args.FileName);
        byte[] key = Encoding.ASCII.GetBytes(AnsiConsole.Prompt(_keyPrompt));
        byte[] iv = Encoding.ASCII.GetBytes(AnsiConsole.Prompt(_ivPrompt));

        CipherMode mode = AnsiConsole.Prompt(_modePrompt);
        PaddingMode padding = AnsiConsole.Prompt(_paddingPrompt);

        AnsiConsole.MarkupLine("[green4]Encrypting...[/]");
        File.WriteAllBytes(args.OutFile, Decrypt.DecryptRc2(iv, key, enc, padding, mode));
    }

    [ArgActionMethod, ArgDescription("Encrypt The Specified File With The Triple Data Encryption Standard (TDES) Algorithm")]
    public void EncryptTripleDes(EncryptArgs args)
    {
        byte[] plain = File.ReadAllBytes(args.FileName);
        byte[] key = Encoding.ASCII.GetBytes(AnsiConsole.Prompt(_keyPrompt));
        byte[] iv = Encoding.ASCII.GetBytes(AnsiConsole.Prompt(_ivPrompt));

        CipherMode mode = AnsiConsole.Prompt(_modePrompt);
        PaddingMode padding = AnsiConsole.Prompt(_paddingPrompt);

        AnsiConsole.MarkupLine("[green4]Encrypting...[/]");

        File.WriteAllBytes(args.OutFile, Encrypt.EncryptTripleDes(iv, key, plain, padding, mode));
    }

    [ArgActionMethod, ArgDescription("Decrypt The Specified File With The Triple Data Encryption Standard (TDES) Algorithm")]
    public void DecryptTripleDes(EncryptArgs args)
    {
        byte[] enc = File.ReadAllBytes(args.FileName);
        byte[] key = Encoding.ASCII.GetBytes(AnsiConsole.Prompt(_keyPrompt));
        byte[] iv = Encoding.ASCII.GetBytes(AnsiConsole.Prompt(_ivPrompt));

        CipherMode mode = AnsiConsole.Prompt(_modePrompt);
        PaddingMode padding = AnsiConsole.Prompt(_paddingPrompt);
        
        AnsiConsole.MarkupLine("[green4]Encrypting...[/]");

        File.WriteAllBytes(args.OutFile, Decrypt.DecryptTripleDes(iv, key, enc, padding, mode));
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