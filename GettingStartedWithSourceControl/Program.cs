using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingStartedWithSourceControl
{
    class Program
    {
        static void Main(string[] args)
        {
            string usersName = getName();
            Console.WriteLine("Hello, " + usersName);
            Console.ReadLine();
        }

        static string getName()
        {
            Console.WriteLine("Enter Your Name: ");
            string name = Console.ReadLine();

            return name;
        }
    }
}
