using System;
using GradeBook;
using Xunit;

namespace gradebook.tests
{
    public class bookTest
    {
        [Fact]
        public void Test1()
        {
            // Arrange
            var book = new Book(""); 
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.3);

            // Act
            var result = book.GetStatistics(book); 

            // Assert
            Assert.Equal(85.6, result.Average,1);
            Assert.Equal(90.5, result.High,1);
            Assert.Equal(77.3, result.Low,1);
        }
    }
}
