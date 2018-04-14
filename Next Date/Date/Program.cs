using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Date
{
    class Program
    {
        static void Main()
        {
            Console.Write("Въведи ден: ");
            int day = int.Parse(Console.ReadLine());
            Console.Write("Въведи месец: ");
            int month = int.Parse(Console.ReadLine());
            Console.Write("Въведи година: ");
            int year = int.Parse(Console.ReadLine());

            if (day > 31)
            {
                Console.WriteLine("Денят не може да е по - голям от 31, но бяха направени автоматични корекции");
                day = 31;
                Console.WriteLine("Може би имахте предвид ден: {0}", day);
                Console.WriteLine("Ето и резулатът от програмата след направените автоматични корекции");
            }
            if (day < 1)
            {
                Console.WriteLine("Денят не може да е по - малък от 1, но бяха направени автоматични корекции");
                day = 1;
                Console.WriteLine("Може би имахте предвид ден: {0}", day);
                Console.WriteLine("Ето и резулатът от програмата след направените автоматични корекции");
            }
            if (month > 12)
            {
                Console.WriteLine("Месецът не може да е по - голям от 12, но бяха направени автоматични  корекции");
                month = 12;
                Console.WriteLine("Може би имахте предвид месец: {0}", month);
                Console.WriteLine("Ето и резулатът от програмата след направените автоматични корекции");
            }
            if (month < 1)
            {
                Console.WriteLine("Месецът не може да е по - малък от 1, но бяха направени автоматични корекции");
                month = 1;
                Console.WriteLine("Може би имахте предвид месец: {0}", month);
                Console.WriteLine("Ето и резулатът от програмата след направените автоматични корекции");
            }
            if (year < 1)
            {
                Console.WriteLine("Годината не може да е по - малка от 1, но бяха направени автоматични корекции");
                year = 1;
                Console.WriteLine("Може би имахте предвид година: {0}", year);
                Console.WriteLine("Ето и резулатът от програмата след направените автоматични корекции");
            }

            // 31 - 1 3 5 7 8 10 12
            // 30 - 4 6 9 11
            // 28/29 - 2

            if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
            {
                if (month == 2 && day == 29)
                {
                    month++;
                    day = 1;
                }
                else
                {
                    day++;
                }
            }
            else if (month == 2 && day == 28)
            {
                day = 1;
                month++;
            }
            else if (month == 2 && day < 28)
            {
                day++;
            }
            else if (month == 2 && day > 28)
            {
                Console.WriteLine("Денят не може да е по голям от 28 при невисокосна година, но бяха направени автоматични корекции");
                day = 1;
                month++;
                Console.WriteLine("Може би имахте предвид ден: 28");
                Console.WriteLine("Ето и резулатът от програмата след направените автоматични корекции");
            }


            else if (month == 1 || month == 3 || month == 5 || month==7 || month == 8 || month == 10 || month == 12)
            {
                if (month == 12 && day == 31)
                {
                    day = 1;
                    month = 1;
                    year++;
                }
                else if (day == 31)
                {
                    month++;
                    day = 1;
                }
                else
                {
                    day++;
                }
            }

            else if (month == 4 || month == 6 || month == 9 || month == 11)
            {
                if (day == 30)
                {
                    month++;
                    day = 1;
                }
                else
                {
                    day++;
                }
            }
            Console.WriteLine("Следващият ден е: {0}/{1}/{2}", day, month, year);

        }
    }
}