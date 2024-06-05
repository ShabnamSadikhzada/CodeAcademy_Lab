namespace CollectionTasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task();
        }

        public static void Task()
        {
            List<int[]> arrays = new();
            int n = 0;
            while (n < 1 || n > 6)
            {
                Console.WriteLine("enter num between 1-6");
                n = Convert.ToInt32(Console.ReadLine());
            }

            Random random = new Random();
            int count = 0, count1 = 0;
            int[] randomNumbers = new int[n];
            int i = 0;
            int newRandom = random.Next(1, 50);
            bool isUnique = true;

            while (count1 < n)
            {
                randomNumbers = new int[n];
                while (count < n)
                {
                    newRandom = random.Next(1, 50);
                    isUnique = true;

                    i = 0;
                    while (i < count)
                    {
                        if (randomNumbers[i] == newRandom)
                        {
                            isUnique = false;
                            break;
                        }
                        i++;
                    }
                    
                    if (isUnique)
                    {
                        randomNumbers[count] = newRandom;
                        count++;
                    }
                }

                arrays.Add(randomNumbers);
                count1++;
                count = 0;
            }

            //ekrana cixarma
            int l = 0;
            int k = 0;
            int[] arrayTmp = arrays[0];
            while (l < arrays.Count)
            {
                arrayTmp = arrays[l];
                while(k < arrayTmp.Length)
                {
                    Console.Write(arrayTmp[k] + " ");
                    k++;
                }
                Console.WriteLine();
                k = 0;
                l++;
            }
        }
    }
}
