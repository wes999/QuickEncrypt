using PowerArgs;

namespace QuickEncrypt;

public class EncryptArgs
{
    [ArgRequired, ArgPosition(1), ArgDescription("The input file for the program to read the data from"), ArgExistingFile]
    public string FileName { get; set; }

    [ArgRequired, ArgPosition(2), ArgDescription("The output file for the program to write the output data to")]
    public string OutFile { get; set; }
}