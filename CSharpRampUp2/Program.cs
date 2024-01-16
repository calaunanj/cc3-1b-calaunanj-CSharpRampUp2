using System;
using System.Diagnostics.Metrics;
namespace RampUp2
{
    class Program
    {
        static void Main(string[] args)
        {

            //pounds to kg
            Console.WriteLine("Enter Weight in Pounds: ");
            int Pounds = Convert.ToInt32(Console.ReadLine());

            double kg = 0.45359237 * Pounds;

            Console.WriteLine("Weight in Kg: " + kg.ToString("F2") + "kg");

            Console.WriteLine("========================================");
            //miles to kilometers

            Console.WriteLine("Length in Miles: ");
            int Miles = Convert.ToInt32(Console.ReadLine());

            double km = Miles * 1.60934;

            Console.WriteLine("Length in Kilometers: " + km.ToString("F2") + "km");

            Console.WriteLine("========================================");

            //fahrenheit to celsius

            Console.WriteLine("Temperature in Fahrenheit");
            double F = Convert.ToDouble(Console.ReadLine());

            double C = (F - 32) / 1.8;

            Console.WriteLine("Temperature in Celsius: " + C.ToString("F2") + "Celsius");

            Console.WriteLine("========================================");

            //Average age 

            Console.WriteLine("Age of Student 1: ");
            int a1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Age of Student 2: ");
            int a2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Age of Student 3: ");
            int a3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Age of Student 4: ");
            int a4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Age of Student 5: ");
            int a5 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Age of Student 6: ");
            int a6 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Age of Student 7: ");
            int a7 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Age of Student 8: ");
            int a8 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Age of Student 9: ");
            int a9 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Age of Student 10: ");
            int a10 = Convert.ToInt32(Console.ReadLine());

            int average = (a1 + a2 + a3 + a4 + a5 + a6 + a7 + a8 + a9 + a10);
            Console.WriteLine("The average age of the student is: " + average / 10);

            Console.WriteLine("========================================");

            String character0 = "Jinx";
            String character1 = "Vi";
            String character2 = "Caitlyn";
            String character3 = "Ekko";
            String character4 = "Marcus";

            String equipment0 = "Gun";
            String equipment1 = "Grenade";
            String equipment2 = "Club";
            String equipment3 = "Board";

            String skill0 = "<Chronobreak>";
            String skill1 = "<Zap!>";

            String special_item = "Hextech Crystal";

            Console.WriteLine("Jinx vs Ekko\n");

            Console.WriteLine(character3 + " leaps off his " + equipment3 + " and steals the " + special_item + " from " + character0 + ". " +
                  "He then gave it to " + character1 + " and " + character2 + ".\n" +
                    character3 + " got shot as " + character0 + " shot him with her " + equipment0 + " while using " + skill1 + ".\n" +
                  "But " + character3 + "is ahead of her, he used his ultimate skill to revert time " + skill0 + ". " +
                  "He smacked her with his " + equipment2 + ".\n" +
                  "Now, she’s down on the ground, grappling for her life, and pretty much losing. Badly.\n"
                  + character3 + " raised his arm to punch her again, but he hesitates after seeing the fear in the eyes of " + character0 + ".\n" +
                   character0 + "'s expression morphs. Her fear disappears, replaced by a mutual sorrow and empathy.\n" +
                   character0 + " pulls the pin in her " + equipment1 + ". Realization hits " + character3 + ", but a bit too late. " +
                  "With this explosion,\nthe fight results in a draw.");

            Console.WriteLine("========================================");

            
            Console.Write("Enter a number: ");
            int count = Convert.ToInt32(Console.ReadLine());
            if (count <= 0)
            {
                Console.WriteLine("Invalid input");
            }
            else
            {
                for (int i = 1; i <= count; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write(j + " ");
                    }
                    Console.WriteLine("");
                }
            }

            Console.WriteLine("========================================");

            Console.Write("Enter a number: ");
            int count1 = Convert.ToInt32(Console.ReadLine());
            if (count1 <= 0) 
            {
                Console.Write("Invalid input");
            }
            else
            {
                int output = 0;
                for(int i = 1; i <= count1; i++)
                {
                    output += i;
                }
                Console.WriteLine("The input is: " + count1);
                Console.WriteLine("The output is: " + output);
            }

            Console.WriteLine("========================================");

            Console.Write("Enter a number: ");
            int count2 = Convert.ToInt32(Console.ReadLine());
            if (count2 <= 0)
            {
                Console.Write("Invalid input");
            }
            else
            {
                for(int i = count2; i > 0 ; i--)
                {
                    for(int j = 1; j <= i ;j++)
                    {
                        Console.Write(j+" ");
                    }
                    Console.WriteLine();
                } 
            }

            Console.ReadKey();
        }   

    }
}   