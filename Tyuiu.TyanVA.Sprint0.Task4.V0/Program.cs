using Tyuiu.TyanVA.Sprint0.Task4.V0.Lib;

namespace Tyuiu.TyanVA.Sprint0.Task4.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Пример линейной структуры 
            // Вызов метода сложения Addition
            Console.WriteLine(DataService.Addition(1, 5));
            // Вызов метода разности Subtraction
            Console.WriteLine(DataService.Subtraction(5, 1));
            // Вызов метода произведения Multiplication
            Console.WriteLine(DataService.Multiplication(2, 5));
            // Вызов метода деления Division
            Console.WriteLine(DataService.Division(10, 5));
            Console.ReadKey();
        }
    }
}
