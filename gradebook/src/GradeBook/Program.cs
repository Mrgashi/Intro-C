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
            book.AddGrade(90.1);
            book.AddGrade(77.7);
            Book.showStats(book); 
           
           var strudentBook = new Book("Class Grades");
           strudentBook.AddGrade(96.10);
           strudentBook.AddGrade(95.10);
           strudentBook.AddGrade(94.10);
           strudentBook.AddGrade(93.3);
           strudentBook.AddGrade(89.40);
           strudentBook.AddGrade(94.50);
           strudentBook.AddGrade(93.43);
           Book.showStats(strudentBook); 
        }
    }
}
