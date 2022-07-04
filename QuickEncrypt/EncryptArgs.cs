using PowerArgs;

namespace QuickEncrypt;

public class EncryptArgs
{
    [ArgRequired, ArgPosition(1)]
    public string FileName { get; set; }

    [ArgRequired, ArgPosition(2)]
    public string Key { get; set; }

    [ArgRequired, ArgPosition(3)]
    public string Iv { get; set; }

    [ArgRequired, ArgPosition(4)]
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