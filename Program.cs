using System;

namespace ConsoleApp2
{
    class Program
    {

        static int Add(params int[] nums)
        {
            int count = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                count += nums[i];
            }
            return count;
        }

        static int Subtract (params int[] nums)
        {
            int count = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                count -= nums[i];
            }
            return count;
        }

       static  int Multiply (params int[] nums)
        {
            int count = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                count *= nums[i];
            }
            return count;
        }

        static double? Divide (params int[] nums)
        {
            double count = (double)nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    count /= (double)nums[i];
                }
                else
                {
                    Console.WriteLine("Only Chuck Norris can divide by zero!");
                    return null;
                }
            }

            return count;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Add(10, 5, 2, 2, 2, 2, 2));
            Console.WriteLine(Subtract(10, 5));
            Console.WriteLine(Multiply(10, 5));
            Console.WriteLine(Divide(10, 5, 2, 0));
        }
    }
}
