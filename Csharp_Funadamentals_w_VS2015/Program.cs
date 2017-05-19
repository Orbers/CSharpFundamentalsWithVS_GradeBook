using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Funadamentals_w_VS2015
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Your name:");
            string name = Console.ReadLine();

            Console.WriteLine("How many hours of sleep did you get last night?");
            int hoursOfSleep = int.Parse(Console.ReadLine());


            if(hoursOfSleep >= 8)
            {
                Console.WriteLine("you got plenty of sleep");
            }
            else
            {
                Console.WriteLine("you should sleep more");
            }



            Console.WriteLine("Hello " + name);





            Console.ReadKey();
        }
    }
}
