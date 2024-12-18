using System.ComponentModel;

namespace assignment_5
{
    internal class Program
    {
        // value type  passing by value
        // public static void swap (int x,int y)
        //{
        //    int temp;
        //    temp = x;
        //    x = y;
        //    y = temp;

        //}
        // public static void swap2( ref int x, ref int y)
        //{
        //    int temp;
        //    temp = x;
        //    x = y;
        //    y = temp;
        //}

        //public static int arrsum(int[] arr)
        //{

        //    int sum = 0;
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        sum += arr[i];
        //    }
        //    return sum;

        //}
        //public static int arrsum2( ref int[] arr)
        //{

        //    int sum = 0;
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        sum += arr[i];
        //    }
        //    return sum;

        //}
        //public static void sumsub(ref int x,ref int y, ref int z,ref int n) {
        //    int sum = 0;
        //    int sub = 0;
        //    sum = x + y;
        //    sub = z - n;
        //    Console.WriteLine(sum);
        //    Console.WriteLine(sub);
        //}

        //public static int DigitSum(int n)
        //{
        //    int sum = 0;


        //    while (n > 0)
        //    {
        //        sum += n % 10;
        //        n /= 10;
        //    }

        //    return sum;
        //}

        //public static bool isprime(int n)
        //{

        //    if (n <= 1)
        //    {
        //        return false;

        //    }
        //    for (int i = 2; i * i <= n; i++)
        //    {
        //        if (n % i == 0)
        //        {
        //            return false;

        //        }
              

        //    }  return true;
        //}

        static void Main(string[] args)
        {
            #region  1 
            //int a =2;
            //int b=3;
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //swap(a,b);
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //swap2 (ref a,ref b);
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            #endregion

            #region 2

            //int[] arr = { 1, 2, 3 };
            //int result = 0;
            //result = arrsum(arr);
            //Console.WriteLine(result);
            //result = arrsum2(ref arr);
            //Console.WriteLine(result);


            #endregion
            #region 3
            //int a=Convert.ToInt32(Console.ReadLine());
            //int b=Convert.ToInt32(Console.ReadLine());
            //int c=Convert.ToInt32(Console.ReadLine());
            //int d=Convert.ToInt32(Console.ReadLine());
            //sumsub(ref a, ref b, ref c, ref d);



            #endregion

            #region 4
            //int a = Convert.ToInt32(Console.ReadLine());
            //int result;
            //     result=DigitSum(a);
            //Console.WriteLine(result);


            #endregion
            #region 5

            //int a=Convert.ToInt32(Console.ReadLine());
            
            //isprime(a);
            //if (isprime(a))
            //{
            //    Console.WriteLine("prime number");

            //}
            //else 
            //{
            //    Console.WriteLine("not prime ");
            //}
            #endregion



        }
    }
}
