namespace Tyuiu.KhudoiberdievDB.Sprint0.Task2.V0.Test;
    using Tyuiu.KhudoiberdievDB.Sprint0.Task2.V0.Lib;

    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
        var name = "Далер";
            var res = DataService.getMessage(name);
        Assert.AreEqual("Привет..., Далер", res); 
        
        }
    }
