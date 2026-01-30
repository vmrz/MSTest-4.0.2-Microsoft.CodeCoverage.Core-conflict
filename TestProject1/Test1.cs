using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject1;

[TestClass]
public sealed class Test1
{
  [TestMethod]
  public void TestMethod1()
  {
    Assert.AreEqual(2, 1 + 1);
  }
}
