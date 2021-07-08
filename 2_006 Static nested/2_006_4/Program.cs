using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_006_4
{
    static class ExtensionClass
    {
        public static void AcsendingArray(this int[] nums)
        {
            //int temp;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] > nums[j])
                    {
                       int x = nums[i];
                        nums[i] = nums[j];
                        nums[j] = x;
                    }
                }
            }

            // вывод
            Console.WriteLine("Вывод отсортированного массива");
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i]);
            }
            Console.ReadLine();

        }
    }

    class Program
    {
        static void Main()
        {
            int [] nus = { 111, 2, 32, 4, 5};

            nus.AcsendingArray();

            Console.ReadKey();
        }
    }
}
