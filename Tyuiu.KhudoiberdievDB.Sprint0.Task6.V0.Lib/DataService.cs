using System.Numerics;

namespace Tyuiu.KhudoiberdievDB.Sprint0.Task6.V0.Lib
{
    public class DataService

    {
        public static object AdditionArray(int[] numbers)
        {
            var total = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                total = total + numbers[i];
            }
            return total;
        }
        public static object SubstractionArray(int[] numbers)
        {
            var tottal = 0;
            int index = 0;
            while (index < numbers.Length)
            {
                tottal = tottal - numbers[index];
                index++;
            }
            return tottal;

        }
        public static object MultiplicationArray(int[] numbers)
        {
            var total = 1;
            int index = 0;

            while(index < numbers.Length)
            {
                total = total * numbers[index];
                index++;
            }
            return total;
        }
    }
}
