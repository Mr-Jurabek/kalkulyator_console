using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalkulyator_console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // MohirDev platformasi DotNet kursi
            //switch mavzusi yordamida kalkulyator console dasturi
            double a, b;
            string amal;
            Console.WriteLine("1-sonni kiriting!");
            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("2-sonni kiriting!");
            b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Iltimos, matematik amallardan birini tanlang!");
            Console.WriteLine(" +; /; -; * ");
            amal = Console.ReadLine();
            switch(amal)
            {
                case "+": Console.WriteLine(a + b); break;
                case "/": Console.WriteLine(a / b); break;
                case "-": Console.WriteLine(a - b); break;
                case "*": Console.WriteLine(a * b); break;
                default: Console.WriteLine("Iltimos, amalni to'g'ri kiriting!"); break;
            }
            Console.ReadKey();
        }
    }
}
