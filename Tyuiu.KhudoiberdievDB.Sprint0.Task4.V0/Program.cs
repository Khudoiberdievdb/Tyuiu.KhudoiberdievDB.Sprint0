using Tyuiu.KhudoiberdievDB.Sprint0.Task4.V0.Lib;
namespace Tyuiu.KhudoiberdievDB.Sprint0.Task4.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DataService.Addition(5, 8));
            Console.WriteLine(DataService.Multiplication(3, 8));
            Console.WriteLine(DataService.Substraction(88, 4));
            Console.WriteLine(DataService.Division(10,5 ));
            Console.ReadKey();
        }
    }
}
