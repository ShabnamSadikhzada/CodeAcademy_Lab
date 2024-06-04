using System.Diagnostics.Metrics;
using System;

namespace LoopTasks;
internal class Program
{
    static void Main(string[] args)
    {
        /*Console.WriteLine("enter number:");
        int num = Convert.ToInt32(Console.ReadLine());
        Task1();
        Task2();
        Task3(num);*/

        /*Task4();
        Task5();
        Task6();
        Task7();
        Task8();
        Task9();*/
        Task10();

    }

    #region Tasks
    public static void Task1()
    {
        int[] nums = { 7, 77, 99, 20, 2004 };
        int min = nums[0], max = nums[0];

        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] < min)
            {
                min = nums[i];
            }
            if (nums[i] > max)
            {
                max = nums[i];
            }
        }
        Console.WriteLine("min: {0}, max: {1}", min, max);
    }

    public static void Task2()
    {
        Console.WriteLine("enter array's length:");
        int l = Convert.ToInt32(Console.ReadLine());
        int[] nums = new int[l];
        Console.WriteLine("enter array's elements:");

        for (int i = 0; i < l; i++)
        {
            nums[i] = Convert.ToInt32(Console.ReadLine());
        }

        int countOdd = 0, countEven = 0;

        foreach (int i in nums)
        {
            if (i % 2 == 0) countEven++;
            else countOdd++;
        }

        Console.WriteLine("even nums count: {0}, odd nums count: {1}", countEven, countOdd);
    }

    public static void Task3(int num)
    {
        int sum = 0;
        int digit = 0;
        while (num > 0)
        {
            sum += num % 10;
            num = (num - (num % 10)) / 10;
            digit++;
        }
        Console.WriteLine("sum: {0}, digit: {1}", sum, digit);
    }

    #endregion
    public static void Task4()
    {
        int a = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < a; i++)
        {
            Console.WriteLine(new String('*', a)); ;
        }
    }

    public static void Task5()
    {
        int a = Convert.ToInt32(Console.ReadLine());
        int count = 1;

        while (count <= a)
        {
            Console.WriteLine(new String('x', count));
            count++;
        }
    }

    public static void Task6()
    {
        int a = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= a; i++)
        {
            for (int j = 1; j <= a; j++)
            {
                if (i == 1 || i == a || j == 1 || j == a)
                    Console.Write('x');
                else
                    Console.Write(" ");
            }
            Console.WriteLine();
        }

    }

    public static void Task7()
    {
        for (int i = 1; i <= 10; i++)
        {
            for (int j = 1; j <= 10; j++)
            {
                Console.WriteLine("{0} * {1} = {2}", i, j, i * j);
            }
            Console.WriteLine();
        }
    }

    public static void Task8()
    {
        Random random = new Random();
        int randomNum = random.Next(1, 99999999);
        Console.WriteLine("enter 8 digits number:");
        int userNum = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i < 3; i++)
        {
            if (randomNum == userNum)
            {
                Console.WriteLine("your num is correct");
                return;
            }
            else
            {
                Console.WriteLine("try again, you have {0} chance", 3 - i);
            }
            userNum = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("you cant find my num, my num is " + randomNum);
    }

    public static void Task9()
    {
        int[] nums = { 2, 4, 6, 10, 12, 15, 18 };
        int countIkiyeBolunenler = 0;
        int sumOdd = 0, sumEven = 0;

        Console.WriteLine("hem 2ye hem de 3e bolunen elementler:");
        foreach (int num in nums)
        {
            if (num % 2 == 0)
            {
                if (num % 3 == 0)
                {
                    Console.Write(num + " ");
                }
                countIkiyeBolunenler++;
                sumEven++;
            }
            else
            {
                sumOdd++;
            }
        }
        Console.WriteLine();

        int[] ikiyeBolunenler = new int[countIkiyeBolunenler];
        int[] ikiyeBolunmeyenler = new int[nums.Length - countIkiyeBolunenler];
        int temp1 = 0, temp2 = 0;
        foreach (int num in nums)
        {
            if ((num % 2) == 0)
            {
                ikiyeBolunenler[temp1] = num;
                temp1++;
            }
            else
            {
                ikiyeBolunmeyenler[temp2] = num;
                temp2++;
            }
        }

        Console.WriteLine("ikiye bolunenler:");
        foreach (int num in ikiyeBolunenler)
        {
            Console.Write(num + " ");
        }

        Console.WriteLine("ikiye bolunmeyenler:");
        foreach (int num in ikiyeBolunmeyenler)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
        Console.WriteLine("cut edelerin cemi: {0}, tek ededlerin cemi: {1}", sumEven, sumOdd);
    }

    public static void Task10()
    {
        int n = 0;
        while (n < 1 || n > 6)
        {
            Console.WriteLine("enter num between 1-6");
            n = Convert.ToInt32(Console.ReadLine());
        }

        Random random = new Random();
        int count = 0, count1 = 0;
        while (count1 < n)
        {
            int[] randomNumbers = new int[n];
            while (count < n)
            {
                int newRandom = random.Next(1, 50);
                bool isUnique = true;

                for (int i = 0; i < count; i++)
                {
                    if (randomNumbers[i] == newRandom)
                    {
                        isUnique = false;
                        break;
                    }
                }

                if (isUnique)
                {
                    randomNumbers[count] = newRandom;
                    Console.Write(randomNumbers[count] + " ");
                    count++;
                }
                
            }
            Console.WriteLine();
            count1++;
            count = 0;
        }
    }

    public static void Task11()
    {
        Console.WriteLine("");
    }
}
