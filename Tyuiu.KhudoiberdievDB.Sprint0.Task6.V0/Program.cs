using Tyuiu.KhudoiberdievDB.Sprint0.Task6.V0.Lib;
namespace Tyuiu.KhudoiberdievDB.Sprint0.Task6.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numsAray = new int[] { 1, 2, 3, 4, 5, };
            Console.WriteLine("Сумма элеметов массива = "+ DataService.AdditionArray(numsAray));
            Console.WriteLine("Разность элементов массива =" +DataService.SubstractionArray(numsAray));
            Console.WriteLine("Произведение эдементов массива ="+ DataService.MultiplicationArray(numsAray));
            Console.ReadKey();

        }
    }
}
