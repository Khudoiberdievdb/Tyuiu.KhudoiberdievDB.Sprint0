using Tyuiu.KhudoiberdievDB.Sprint0.Task5.V0.Lib;
namespace Tyuiu.KhudoiberdievDB.Sprint0.Task5.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A + B =" + DataService.Addition(5, 8));
            Console.WriteLine("A * B =" + DataService.Multiplication(3, 8));
            Console.WriteLine("A - B =" + DataService.Substraction(88, 4));
            Console.WriteLine("A / B =" + DataService.Division(10, 2));
            Console.ReadKey();
        }
    }
}
