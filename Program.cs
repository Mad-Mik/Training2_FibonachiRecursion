using System;

namespace Training2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Fibonachi Recursion
            string number = Console.ReadLine();
            int y = Convert.ToInt32(number);
            int x = Fibonachi(y);
            Console.WriteLine(x);
        }
        static int Fibonachi(int n)

        {
            if (n == 0 || n == 1)
                return n;

            else
                return Fibonachi(n - 1) + Fibonachi(n - 2);
        }



    }
}

