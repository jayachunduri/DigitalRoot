using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalRoot
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digital Root of 31337 is: ");
            DigitalRoot(31337);

            Console.WriteLine("\nDigital Root of 45734 is: ");
            DigitalRoot(45734);
        }

        static void DigitalRoot(int num)
        {
            string sNum = num.ToString();
            int total = 0; //variable to keep track of total of the numbers

            //looping through each number
            foreach (var item in sNum)
            {
                total += int.Parse(item.ToString());
            }

            if (total.ToString().Length > 1) //means total is more than one digit
            {
                DigitalRoot(total);
            }

            else
                Console.WriteLine(total);
        }
    }
}
