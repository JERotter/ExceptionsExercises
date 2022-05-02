using System;
using System.Collections.Generic;

//Exercises for the Exceptions Chapter

namespace csharp_web_dev_lsn9exceptions
{
    class Program
    {
        
        static double Divide(double x, double y)
        {
            // Write your code here!
            if (y == 0)
            {
                throw new ArgumentOutOfRangeException("Can't divide by zero!");
            }
            return x/y;
        }

        static int CheckFileExtension(string fileName)
        {
            // Write your code here!
            int points = 0;
            if (fileName.Contains(".cs"))
            {
                points++;
            }
            return points;
        }


        static void Main(string[] args)
        {
            // Test out your Divide() function here!

            try
            {
                Divide(5, 0);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }

            //Test out your CheckFileExtension() function here!
            Dictionary<string, string> students = new Dictionary<string, string>();
            students.Add("Carl", "Program.cs");
            students.Add("Brad", "");
            students.Add("Elizabeth", "MyCode.cs");
            students.Add("Stefanie", "CoolProgram.cs");


            foreach (KeyValuePair<string, string> student in students)
            {
                Console.WriteLine(student.Key + " : " +CheckFileExtension(student.Value) + "pts");
            }


        }
    }
}