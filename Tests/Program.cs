using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuickEncrypt;

namespace Tests;

[TestClass]
class Program
{
    [TestMethod]
    public void TestMd5()
    {
        string hash = BitConverter.ToString(Hash.GetMd5("filename")).Replace("-", string.Empty);

        Assert.IsTrue(hash == "");
    }
}