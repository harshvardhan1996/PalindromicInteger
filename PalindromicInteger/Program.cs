using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromicInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int number = int.Parse(Console.ReadLine());
            if(IsPalindrome(number))
            {
                Console.WriteLine("Number is Palindromic");
            }
            else
            {
                Console.WriteLine("Number is not Palindromic");
            }
            Console.ReadKey();
        }
        public static bool IsPalindrome(int x)
        {
            if (x < 0)
                return false;

            if (Reverse(x) == x)
                return true;
            else
                return false;

        }
        public static int Reverse(int x)
        {
            int rem;
            int rev1 = 0;
            int rev = 0;

            if (x > 0)
            {
                while (x != 0)
                {
                    rem = x % 10;
                    if (rev > Int32.MaxValue / 10 || (rev == Int32.MaxValue / 10 && rem > 7)) return 0;
                    if (rev < Int32.MinValue / 10 || (rev == Int32.MinValue / 10 && rem < -8)) return 0;
                    rev = rev * 10 + rem;
                    x = x / 10;
                }

            }

            if (x < 0)
            {
                int num = -x;
                while (num != 0)
                {
                    rem = num % 10;
                    if (rev1 > Int32.MaxValue / 10 || (rev1 == Int32.MaxValue / 10 && rem > 7)) return 0;
                    if (rev1 < Int32.MinValue / 10 || (rev1 == Int32.MinValue / 10 && rem < -8)) return 0;
                    rev1 = rev1 * 10 + rem;
                    num = num / 10;
                }
                rev = -(rev1);
            }
            return rev;
        }
    }
}
