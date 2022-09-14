using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    sealed class Calculator
    {
        private decimal Result { get; set; }
        private string Equal { get; set; }
        private decimal Input { get; set; }
        private bool Check { get; set; }
        public Calculator()
        {
            do
            {
                
                Console.Write("[+] Or [-] Or [/] Or [*]\t:\t");
                string process = Console.ReadLine();
                Check = false;
                if (process.Contains("+")) { Add(); }
                else if (process.Contains("-")) { Minus(); }
                else if (process.Contains("*")) { Multipy(); }
                else if (process.Contains("/")) { Divide(); }
                else Check = true;
            }
            while (Check);
        }
        private void Add()
        {
            int i = 0;
            while (!Check)
            {
                ++i;
                Console.Write($"Enter {i} Number: ");
                Input = decimal.Parse(Console.ReadLine());
                Result += Input;
                if (i % 2 == 0)
                {
                    Continue();
                    CheckEqual();
                }
            }
        }
        private void Minus()
        {
            int i = 0;
            while (!Check)
            {
                ++i;
                Console.Write($"Enter {i} Number: ");
                Input = decimal.Parse(Console.ReadLine());
                if (i == 1)
                    Result = Input;
                else
                    Result -= Input;
                if (i % 2 == 0)
                {
                    Continue();
                    CheckEqual();
                }
            }
        }
        private void Multipy()
        {
            int i = 0;
            while (!Check)
            {
                ++i;
                Console.Write($"Enter {i} Number: ");
                Input = decimal.Parse(Console.ReadLine());
                if (i == 1)
                    Result = Input;
                else
                    Result *= Input;
                if (i % 2 == 0)
                {
                    Continue();
                    CheckEqual();
                }
            }
        }
        private void Divide()
        {
            int i = 0;
            while (!Check)
            {
                ++i;
                Console.Write($"\nEnter {i} Number: ");
                Input = decimal.Parse(Console.ReadLine());
                if (i == 1)
                    Result = Input;
                else
                    Result /= Input;
                if (i % 2 == 0)
                {
                    Continue();
                    CheckEqual();
                }
            }
        }
        private void Continue()
        {
            Console.WriteLine("Contiue or = !!");
            Equal = Console.ReadLine();
        }
        private void CheckEqual()
        {
            if (Equal == "=")
            {
                Console.WriteLine(Result);
                Result = 0;
                Equal = "";
                Check = true;
            }
        }
    }
}
