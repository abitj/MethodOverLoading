using System;

namespace MethodOverLoading
{
    class Program
    {

        // create an Add method that accepts two integers and returns their sum
        // create an overload of the Add method to add two decimals together
        // create an overload of the Add method that returns a string and accepts 3 parameters: 2 integers and 1 boolean
        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static decimal Add(decimal num1, decimal num2)
        {
            return num1 + num2;
        }

        public static string Add(int num1, int num2, bool isCheck)
        {
            var sum = num1 + num2; 

            if(isCheck == true && sum > 1)
            {
                return $"{sum} dollars";
            }
            else if (isCheck == true && sum == 1)
            {
                return $"{sum} dollar";
            }
            else
            {
                return sum.ToString();
            }
        }


        static void Main(string[] args)
        {
            var a = 55;
            var b = 21;
            var res = Add(a,b);

            var x = 46.0m;
            var y = 16.0m;

            var decimalRes = Add(x,y);
            var booleanRes = Add(a,b,true);

            Console.WriteLine();
            Console.WriteLine($"The answer to int add method is {res} and the decimal add method is {decimalRes}");
            Console.WriteLine($"The answer to method with boolean is {booleanRes}.");
            Console.WriteLine("-------------------------------------------------------------------------------------");
        }    
    }
}
