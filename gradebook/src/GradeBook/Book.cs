using System.Collections.Generic;
using System;

namespace GradeBook
{
    public class Book
    {
        private string name;
        private static List<double> grades = new List<double>(); 
        public Book(string name)
        {
            this.name = name; 
            grades = new List<double>();    
        } 
       public void AddGrade(double grade) 
       {
           grades.Add(grade); 
       }

        public static void showStats(Book book) 
       {
            var result = 0.0;
            var highGrade = double.MinValue;
            var lowGrade = double.MaxValue;

            foreach (double grade in grades)
            {
                highGrade = Math.Max(grade, highGrade);
                lowGrade = Math.Min(grade, lowGrade);
                result += grade;
            }
            result /= grades.Count;
            Console.WriteLine($"{book.name}\nThe avarage grade is: {result:N1}.\nThe lowest number is: {lowGrade:N2}. \nThe highest grade is {highGrade:N2} ");
       }
    }
}