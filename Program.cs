namespace Easy_Level
{
    internal class Program
    {
        static void Main(string[] args)
        {

           


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
        static int getAbsSum(int[] nums )
        {
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                int positiveValue = nums[i] < 0 ? - nums[i] : nums[i] ;
                sum += positiveValue;
            }
            return sum;
        }
        static double СalculateExponent(int b, int exponent)
        {
            return Math.Pow(b,exponent);
        }//1
        static void  MultiplyByLength(int[] nums)
        {
            if (nums.Length == 0) return;
            else
            {


                int[] result = new int[nums.Length];
                for (int i = 0; i < nums.Length; i++)
                {
                    result[i] = nums[i] * nums.Length;
                    Console.Write($" {result[i]} , ");
                }

            }
        }  // 2 
        static int HammingDistance(string input, string input1)
        {
            int dis = 0;
            for (int i = 0;i < input1.Length;i++)
            {
                if (input[i] != input1[i])
                    dis++;
            }
            return dis;
        }  //3
        static void NameShuffle(string name)
        {
            string[] inputs = name.Split(' ');
            string f = inputs[1];
            string l = inputs[0];
            Console.WriteLine($"{f} {l}");
        }  //4
        static int smallerNum(string[] n)
        {
            int input = int.Parse(n[0]);
            int input2 = int.Parse(n[1]);
            int res = input <= input2 ? input : input2;  
            return res;
        }     //5
    }
}
