using Tyuiu.TyanVA.Sprint0.Task2.V0.Lib;
namespace Tyuiu.TyanVA.Sprint0.Task2.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Вызов класса DataService и метода GetMessage
            //Из библиотеки Tyuiu.TyanVA.Sprint1.Task2.V0.Lib
            Console.WriteLine(DataService.GetMessage("Влад")); 
            Console.ReadKey();
        }
    }
}
