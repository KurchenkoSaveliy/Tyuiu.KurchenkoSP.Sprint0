using Tyuiu.KurchenkoSP.Sprint0.Task2.V0.Lib;
namespace Tyuiu.KurchenkoSP.Sprint0.Task2.V0.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Савелий";
            var res = DataService.GetMessage(name);
            Assert.AreEqual($"Привет... , Савелий", res);
        }
    }
}
