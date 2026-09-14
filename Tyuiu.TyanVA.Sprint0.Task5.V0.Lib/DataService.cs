namespace Tyuiu.TyanVA.Sprint0.Task5.V0.Lib
{
    public class DataService
    {
        // Пример линейной функции Сумма
        public static int Addition(int a, int b)
        {
            return a + b;
        }
        // Пример линейной структуры разность
        public static int Subtraction(int a, int b)
        {
            return a - b;
        }
        // Пример линейной функции Произведение 
        public static int Multiplication(int a, int b)
        {
            return a * b;
        }
        // Пример линейной структуры Деление
        public static double Division(int a, int b)
        {
            if (b == 0)
            {
                    Console.WriteLine("Переменная b = {0} на ноль делить нельзя", b);
                    return -1;
            }  
            else
            {
                return a / b;
            }
        
        }
        
    }
}
