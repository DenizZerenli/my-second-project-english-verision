using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test5_english_verision
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the Math Exam Scores of Student Alex: ");
            Console.WriteLine();

            double exam1, exam2, exam3, exam4, result;

            Console.WriteLine("Please enter the 1st exam score: ");
            exam1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the 2nd exam score: ");
            exam2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the 1st oral exam score: ");
            exam3 = double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the 2nd oral exam score: ");
            exam4 = double.Parse(Console.ReadLine());

            result = (exam1 + exam2 + exam3 + exam4) / 4;

            Console.Clear();

            Console.WriteLine();
            Console.WriteLine("Average of student Alex: " + result);


            Console.WriteLine();
            Console.WriteLine("Enter the Math Exam Scores of Student Michel: ");
            Console.WriteLine();

            double sınav1, sınav2, sınav3, sınav4, sonuç;

            Console.WriteLine("Please enter the 1st exam score: ");
            sınav1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the 2nd exam score: ");
            sınav2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the 1st oral exam score: ");
            sınav3 = double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the 2nd oral exam score: ");
            sınav4 = double.Parse(Console.ReadLine());

            sonuç = (sınav1 + sınav2 + sınav3 + sınav4) / 4;

            Console.WriteLine();
            Console.WriteLine("Average of student Michel: " + sonuç);

            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("You have entered the math averages of 2 students: ");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Average of student Arthur: " + result);
            Console.WriteLine("------------------------");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Average of student Michel: " + sonuç);

            Console.Read();


        }
    }
}
