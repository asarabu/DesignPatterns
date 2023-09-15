namespace LeetCode1
{
    internal class Program
    {


        static void Main(string[] args)
        {
            //int[] s = { 2, 7, 11, 15 };

            //var result = Solution.TwoSum(s, 9);

            //var result1 = Solution.IsPalidrome(121);

            //Console.WriteLine($"[{result[0]}, {result[1]}]");

           var result = Solution.RomanToInt("MCMXCVI");

            Console.WriteLine(result);
            Console.ReadLine();

        }
    }

    public static class Solution
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            var result = new int[2];
            for (var i = 0; i< nums.Length - 1; i++)
            {
                if ((nums[i] + nums[i+1]) == (target))
                {
                    result[i] = i;
                    result[i+1] = i+1;
                }
            }

            return result;

        }

        public static bool IsPalidrome(int x)
        {
            int r = 0, c = x;
            while (c > 0)
            {
                r = r * 10 + c % 10;
                c /= 10;
            }
            return r == x;
        }


        public static int RomanToInt(string s)
        {
            var list = new Dictionary<string, int>()
            {
                { "I", 1 }, { "V", 5 }, { "L", 50 },{ "C", 100 },{ "D", 500 },{ "M", 1000 },{ "X", 10 }
            };

            int sum = 0;
            var y = s.Length - 1;

            for (int i = 0; i <= s.Length -1; i++)
            {
                for (int j = i+1; j < s.Length; j++)
                {
                    if (list[s[i].ToString()] > list[s[j].ToString()])
                    {
                        sum+= list[s[i].ToString()];

                        if (i<j && ((s.Length -1) - j)==1)
                        {

                            sum += list[s[y].ToString()];
                        }

                        break;
                    }
                    else if (list[s[i].ToString()] < list[s[j].ToString()])
                    {
                        var q = list[s[j].ToString()] - list[s[i].ToString()];

                        sum = sum + q;

                        i = j;
                        if (((s.Length -1) - j)==1)
                        {

                            sum += list[s[y].ToString()];
                        }

                        break;
                    }
                    else if (list[s[i].ToString()] == list[s[j].ToString()])
                    {
                        sum+= list[s[i].ToString()];

                        if (((s.Length -1) - j)==1)
                        {

                            sum += list[s[y].ToString()];
                        }

                        break;
                    }

                    if (i < j && ((s.Length -1) - j)==1)
                    {

                        sum += list[s[y].ToString()];
                    }

                    break;
                }

            }
            return sum;
        }
    }
}