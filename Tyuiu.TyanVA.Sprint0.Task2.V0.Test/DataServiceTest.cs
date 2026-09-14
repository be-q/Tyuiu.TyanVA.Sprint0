using Tyuiu.TyanVA.Sprint0.Task2.V0.Lib; 

namespace Tyuiu.TyanVA.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            // Область создания методов тестирования, методов из библиотеки
            var name = "Влад";
            var res = DataService.GetMessage(name);

            // Называем класс Assert и метод AreEqual
            Assert.AreEqual("Привет..., Влад", res);
        }
    }
}
