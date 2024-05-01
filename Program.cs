namespace Easy_Level
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = { 1, 2, 3, 4, 5 };
            int[] array2 = { 2334454, 5 };
            int[] array3 = { 1 };

           // int[] res1 = MinMax(array1); 
            int[] res2 = MinMax( array2); 
           // int[] res3 = MinMax(array3);

            Console.WriteLine($"{res2[0]}  {res2[1]} ");
            Console.WriteLine($"{array2[0]}  {array2[1]} ");

        }
        static int[] MinMax( int[] nums)
        {
            if (nums.Length == 0)
                return nums;

            int min = nums[0];
            int max = nums[0];

            foreach (var item in nums)
            {
                if (item < min) 
                    min = item;
              else if (item > max) 
                    max = item;

            }
            return new int[] { min, max };
        }
    }
}
