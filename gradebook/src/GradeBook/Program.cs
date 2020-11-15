using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Scotts grade book"); 
            book.AddGrade(89.1); 
            book.AddGrade(90.5);
            book.AddGrade(77.3);
            var stats1= book.GetStatistics(book);  

            System.Console.WriteLine($"The lowest grade is {stats1.Low}");
            System.Console.WriteLine($"The highest grade is {stats1.High}");
            System.Console.WriteLine($"The avarage grade is {stats1.Average}");
           
            
           
        }
    }
}
