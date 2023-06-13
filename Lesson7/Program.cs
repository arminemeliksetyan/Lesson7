namespace Lesson7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(Calc(12));

            int[] ayArray = { 1, 2, 13, 44, -55, 6, 7, 8, 9, 10, 11, };
            int sum;
            int p = 1;
            int startIndex = 5;
            Calc(ref ayArray, ref p, out sum, in  startIndex);
        }

        //ref , out , in

        static void Calc(int[] arr, int p, int sum) 
        {
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] *= 2;
                if (arr[i] % 2 != 0) 




                {
                    p*= arr[i];
                }
                else
                {
                    sum *= arr[i];
                }
            }
        }


        // faktorial

        //static double Calc(int a)
        //{
        //    if (a > 1)
        //    {
        //        return a * Calc(a - 1);
        //    }
        //    else return a;
        //}
    }
}