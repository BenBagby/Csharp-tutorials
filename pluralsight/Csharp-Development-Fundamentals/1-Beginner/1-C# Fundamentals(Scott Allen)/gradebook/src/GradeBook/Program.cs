using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        // This is a method, named Main
        // Inside of the parenthesis of the method we have parameters
        // every parameter has a type and a name of the parameter
        // the name of this parameter is args
        // the type of this parameter is string array, the square brakets dictate array
        {
            // C# is zero-based indexing
            // string concatination
            if(args.Length > 0)
            {
                Console.WriteLine("Hello " + args[0] + "!");
                // string interpolation
                // inside of curly braces is an expression
                Console.WriteLine($"Hello, {args[0]}!");
            }
            else
            {
                Console.WriteLine("Hello!");
            }
        }
    }
}
