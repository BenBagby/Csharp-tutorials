using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var book = new Book("Ben's Grade Book");

            var done = false;

            while(!done)
            {
                Console.WriteLine("Enter a grade or 'qq to quit");
                var input = Console.ReadLine();
                
                if(input == "q")
                {
                    done = true;
                    continue;
                }

                try
                {
                    var grade = double.Parse(input);
                    book.AddGrade(grade);
                }
                catch(ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch(FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.WriteLine("**");
                }

            }
            
            


            book.GetStatistics();

            var stats = book.GetStatistics();
            Console.WriteLine($"The lowest grade is {stats.Low:N1}");
            Console.WriteLine($"The highest grade is {stats.High:N1}");
            Console.WriteLine($"The average grade is {stats.Average:N1}");
            Console.WriteLine($"The Letter grade is {stats.Letter}");

        }
    }
}
