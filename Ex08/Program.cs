using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex08
{
    class Program
    {
        static void Main(string[] args)
        {
            int dayofweek = 5;

            switch (dayofweek)
            {
                case 1:
                    Console.WriteLine("Luni");
                    break;
                case 2:
                    Console.WriteLine("Marti");
                    break;
                case 3:
                    Console.WriteLine("Miercuri");
                    break;
                case 4:
                    Console.WriteLine("Joi");
                    break;
                case 5:
                    Console.WriteLine("Vineri");
                    break;
                case 6:
                    Console.WriteLine("Sambata");
                    break;
                default:
                    Console.WriteLine("Duminica");
                    break;
            }
        }
    }

}
    