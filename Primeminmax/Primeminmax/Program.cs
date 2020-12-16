using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primeminmax
{
    class Program
    {

        public void PrimePrint()
        {
            int num, i, count, no1, no2;

            Console.Write("Input starting number of range: ");
            no1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input ending number of range : ");
            no2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("The prime numbers between {0} and {1} are : \n", no1, no2);

            for (num = no1; num <= no2; num++)
            {
                count = 0;

                for (i = 2; i <= num / 2; i++)
                {
                    if (num % i == 0)
                    {
                        count++;
                        break;
                    }
                }

                if (count == 0 && num != 1)
                    Console.Write("{0} ", num);
            }
            Console.Write("\n");
			Console.Write("Changed By Neel");
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.PrimePrint();
            Console.ReadKey();
        }
    }
}
