using System;
using System.Linq;

namespace mcm_mcd
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Insert the numbers separated by , : ");
            string input = Console.ReadLine();

            Console.WriteLine("LCM / MCD ? [1/2]");
            string choose = Console.ReadLine();

            if (choose == "1")
            {
                string[] str_list = input.Split(",");
                int[] int_list = str_list.Select(int.Parse).ToArray();
                int mcm = CalculateMCM(int_list);
                Console.Clear();
                Console.WriteLine($"LCM: {mcm}");
            }
            else if (choose == "2")
            {
                string[] str_list = input.Split(",");
                int[] int_list = str_list.Select(int.Parse).ToArray();
                int mcd = CalculateMCD(int_list);
                Console.Clear();
                Console.WriteLine($"MCD: {mcd}");
            }
            else
            {
                Console.WriteLine("Error 1");
            }
        }
        public static int CalculateMCM(int[] numbers)
        {
            int maxNum = numbers.Max();
            int mcm = maxNum;

            while (true)
            {
                if (numbers.All(n => mcm % n == 0))
                {
                    return mcm;
                }
                mcm += maxNum;
            }
        }
        public static int CalculateMCD(int[] numbers)
        {
            int result = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                result = GCD(result, numbers[i]);
            }
            return result;
        }
        public static int GCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
    }
}
