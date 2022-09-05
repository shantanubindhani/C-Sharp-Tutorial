using System;

// SECTION
/*
    Variables : defines and states the condition to name variables in C#

    Data types : demonstrates the basic built-in data types in c#

    Printing : demonstrates how to print text and variables onto the screen

*/

namespace l1
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Variables
            /*
                Variables are names given to a memory location.
                they are used to reserve memory, and as their name suggests,
                they can be changed anywhere throughout the program, hence variable.

                Variables also have names, and some condition to name them
                    1. Can contain letters, numbers and underscore(_)
                    2. Must start with a letter/underscore.
                
                Note : keep the names descriptive for the data they store.
            */
            
            // Data types
            /*
            int : integer
            float : floating/decimal point numbers
            double : more precise version of float
            char : single character
            bool : true or false
            string : sequence of characters
            */

            // Initializing variables
            int x = 12;
            float radius = 7.12f; // adding a postfix 'f' tells the compiler that this is a float instead of double
            double pi = 3.14162;
            char ch = 'a';
            bool isLeft = true;
            string my_name = "Shantanu Kumar Bindhani";

            // Printing
            Console.WriteLine(" value of x is : " + x); // WriteLine() automatically adds a \n(newline) character at the end of printing
            Console.Write(" randome radius : " + radius); // Write() prints the text as intended, hence the next print is not printed in a new line.
            
            Console.WriteLine(" | value of pi : " + pi); // the + operator combines different data types into a single string format for printing
            Console.WriteLine(" The name " + my_name + " has the character '" + ch + "' more than once.");
            Console.Write(" is my heart of the left side? : " + isLeft + "\n");
        }
    }
}
