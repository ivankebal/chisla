using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Chislo chislo = new Chislo();
            chislo.Metod();
        }
    }
    class Chislo
    {
        string i;
        int colichestvo;

        public void Metod()
        {
            Console.Write("Введите число: ");
            i = Console.ReadLine();
            int a = 0;

            while (a <= i.Length)
            {
                colichestvo = a++;
            }
            Console.WriteLine("Количество цифр {0}", colichestvo);
            Console.ReadKey();
        }
        }
    }

