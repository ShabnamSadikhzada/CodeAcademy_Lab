namespace ArrayFunctionsPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //FindMin();
            //FindOrtalama();
            //Console.WriteLine(IsComplex(9));
            FindSimpleOrComplexInArray();
        }

        public static void FindMin()
        {
            /*int[] nums = { 0, 50, -11, 23, 18 };
            int[] nums1 = new int[nums.Length];
            nums.CopyTo(nums1, 0);
            Array.Sort(nums1);
            int min = nums1[0];
            int index = Array.IndexOf(nums, min);
            Console.WriteLine("Min eded:{0}, Min ededin indexi:{1}", min, index);*/

            int[] nums = { 0, 50, -11, 23, 18 };
            int min = nums[0];
            int minIndex = 0;
            for (int i = 1; i < nums.Length; i++)
            {
                if (min >= nums[i])
                {
                    min = nums[i];
                    minIndex = i;
                }
            }

            Console.WriteLine("Min eded:{0}, Min ededin indexi:{1}", min, minIndex);
        }

        public static void FindOrtalama()
        {
            int[] nums = { 0, 50, -11, 23, 18 };
            int sum = 0;
            for (int i = 1; i < nums.Length; i++)
            {
                sum += nums[i];
            }
            double ortalama = sum / (nums.Length);
            Console.WriteLine("ortalama:{0}", ortalama);
        }

        public static void FindSimpleOrComplexInArray()
        {
            int simpleCount = 0, complexCount = 0;
            Console.WriteLine("enter array size:");
            int l = Convert.ToInt32(Console.ReadLine());
            int[] nums = new int[l];
            Console.WriteLine("enter array's elements:");
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = Convert.ToInt32(Console.ReadLine());
                if (IsComplex(nums[i]))
                {
                    complexCount++;
                }
                else 
                {
                    simpleCount++;
                }
            }
            int[] simpleElements = new int[simpleCount];
            int[] complexElements = new int[complexCount];

            int count = 0;
            for(int i = 0;i < nums.Length; i++)
            {
                if(!IsComplex(nums[i]))
                {
                    simpleElements[count++] = nums[i];
                }
                if(count == simpleCount)
                {
                    break;
                }
            }

            count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (IsComplex(nums[i]))
                {
                    complexElements[count++] = nums[i];
                }
                if (count == complexCount)
                {
                    break;
                }
            }

            Console.WriteLine("Complex array:");
            DisplayArray(complexElements);

            Console.WriteLine("Simple array:");
            DisplayArray(simpleElements);
        }

        public static bool IsComplex(int num) 
        {
            int count = 0;
            for(int i = 1;i < num/2; i++)
            {
                if(num%i == 0)
                {
                    count++; 
                }
            }

            if(count >=2)
            {
                return true;
            }
            return false;
        }

        public static void DisplayArray(int[] arr)
        {
            for(int i = 0; i<arr.Length; i++)
            {
                Console.WriteLine(arr[i] + " ");
            }
        }
    }
}
