namespace IfElseTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 12;
            EvenOrOdd(num);
            PositiveOrNegative(num);

            int gpa = 99;
            CheckGPA(gpa);
        }

        public static void EvenOrOdd(int num)
        {
            if (num <= 0)
            {
                Console.WriteLine("your num is not even or odd");
                return;
            }
            if (num % 2 == 0)
            {
                Console.WriteLine("your num is even");
            }
            else
            {
                Console.WriteLine("your num is odd");
            }
        }
        
        public static void PositiveOrNegative(int num) 
        {
            if(num == 0)
            {
                Console.WriteLine("your num is not positive or negative");
                return;
            }
            if (num > 0)
            {
                Console.WriteLine("your num is positive");
            }
            else
            {
                Console.WriteLine("your num is negative");
            }
        }

        public static void CheckGPA(int gpa)
        {
            if (gpa >= 91) 
            {
                Console.WriteLine("elaci");
            }
            else
            {
                Console.WriteLine("elaci doul");
            }
        }
    }
}
