using System;

namespace methodExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Addition:");
            Console.WriteLine(Add(9, 4));
            Console.WriteLine("Subtraction:");
            Console.WriteLine(Sub(233, 76));
            Console.WriteLine("Multiplication:");
            Console.WriteLine(Mult(33, 6));
            Console.WriteLine("Division:");
            Console.WriteLine(Div(370, 5));

            Console.WriteLine(ParamsAdd(2, 4));
            Console.WriteLine(ParamsAdd(2, 4, 6));
            Console.WriteLine(ParamsAdd(1, 1, 1, 1, 1));
        }

        public static int Add(int x, int y)
        {
            return x + y; 
        }

        public static int Sub(int x, int y)
        {
            return x - y;
        }

        public static int Mult(int x, int y)
        {
            return x * y;
        }

        public static int Div(int x, int y)
        {
            return x / y;
        }

        public static int ParamsAdd(params int[] nums)
        {
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }
            return sum;
        }
    }
}

