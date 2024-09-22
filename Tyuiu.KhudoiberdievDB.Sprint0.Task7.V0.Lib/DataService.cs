namespace Tyuiu.KhudoiberdievDB.Sprint0.Task7.V0.Lib
{
    public class DataService
    {
        public static int[] AdditionArrays(int[] numOne, int[] numTwo)
        {
            int[] ResultArray = new int[5];
            for (var i = 0 ; i < numOne.Length; i++)
            {
                ResultArray[i] = numOne[i] + numTwo[i];
            }
            return ResultArray;
        
        }
    }
}
