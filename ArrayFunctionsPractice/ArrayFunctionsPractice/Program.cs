namespace ArrayFunctionsPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FindMin();
            FindOrtalama();
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
    }
}
