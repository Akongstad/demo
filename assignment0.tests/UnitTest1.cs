using System;
using System.IO;
using Xunit;

namespace assignment0.tests
{
    public class UnitTest1
    {
        [Fact]
        public void isLeapYear_checks_divide_4()
        {
            /*Arrange
            StringWriter writer = new StringWriter();
            Console.SetOut(writer);
            //Act
            Program.Main(new string[0]);
            //Assert
            var output = writer.GetStringBuilder().ToString();
            Assert.Equal("Hello world!", output);
            */
            var program = new Program();
            var expected = true;
            Assert.Equal(expected, program.isLeapYear(4));
            
            
        }
        [Fact]
        public void isLeapYear_checks_divide_100(){
            var program = new Program();
            var expected = false;
            Assert.Equal(expected, program.isLeapYear(200));
        }
        [Fact]
        public void isLeapyear_checks_divide_400()
        {
            var program = new Program();
            var expected = true;
            Assert.Equal(expected, program.isLeapYear(400));
        
        }
        [Fact]
        public void isLeapYear_checks_0()
        {
            var program = new Program();
            var expected = false;
            Assert.Equal(expected, program.isLeapYear(0));
        }
    }
}
