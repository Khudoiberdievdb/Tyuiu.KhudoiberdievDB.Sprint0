using Tyuiu.KhudoiberdievDB.Sprint0.Task5.V0.Lib;
namespace Tyuiu.KhudoiberdievDB.Sprint0.Task5.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedAdditionValid()
        {
            Assert.AreEqual(10, DataService.Addition(5, 5));
        }
        [TestMethod]
        public void CheckedMiltiplicationValid()
        { Assert.AreEqual(25, DataService.Multiplication(5, 5)); }
        [TestMethod]
        public void CheckedSubstractionValid()
        {
            Assert.AreEqual(0, DataService.Substraction(5, 5));
        }
        [TestMethod]
        public void CheckedDivisionValid()
        {
            Assert.AreEqual(5, DataService.Division(25, 5));
        }
    }
}
