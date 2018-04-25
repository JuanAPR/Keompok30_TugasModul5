using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keompok30_TugasModul5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Quiz: Check Your Personality!!");
            string choice;
            Console.WriteLine("Ready for the Quiz?");
            Console.WriteLine("Y/N");
            choice = Console.ReadLine();
            if (choice == "Y" || choice == "y")
            {
                progam();
                 
            } else if (choice == "N" || choice == "n")
            {
                Environment.Exit(0);
            } else
            {
                Console.WriteLine("Invalid Input");
                Console.WriteLine("Press Anything to Continue");
                Console.ReadKey();
                Main(null);
            }
        }
        static void progam()
        {
            string nama1;
            Console.Clear();
            Console.WriteLine("Quiz: Check Your Personality!!");
            Console.WriteLine("Please Write Your Name: ");
            nama1 = Console.ReadLine();
            InOut quiz = new InOut();
            quiz.setInput("" + nama1);
            Console.WriteLine("Quiz Start!");

            Pertanyaan quize = new Pertanyaan();
            quize.Quest();
            Console.ReadKey();
        }
    }
}
