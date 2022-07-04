using PowerArgs;

namespace QuickEncrypt;

public class EncryptArgs
{
    [ArgRequired, ArgPosition(1), ArgDescription("The input file for the program to read the data from"), ArgExistingFile]
    public string FileName { get; set; }

    [ArgRequired, ArgPosition(2), ArgDescription("The 32 character long encryption key, any valid ascii character can be used in the key")]
    public string Key { get; set; }

    [ArgRequired, ArgPosition(3), ArgDescription("The 16 character long initialization vector, any valid ascii character can be used in the iv")]
    public string Iv { get; set; }

    [ArgRequired, ArgPosition(4), ArgDescription("The output file for the program to write the output data to")]
    public string OutFile { get; set; }

    public EncryptArgs(){ }

    public EncryptArgs(string fileName, string key, string iv, string outFile)
    {
        FileName = fileName;
        Key = key;
        Iv = iv;
        OutFile = outFile;
    }
}