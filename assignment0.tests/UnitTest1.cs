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
            Assert.Equal(expected, program.isLeapYear(1584));
            
            
        }
        [Fact]
        public void isLeapYear_checks_divide_100(){
            var program = new Program();
            var expected = false;
            Assert.Equal(expected, program.isLeapYear(1800));
        }
        [Fact]
        public void isLeapyear_checks_divide_400()
        {
            var program = new Program();
            var expected = true;
            Assert.Equal(expected, program.isLeapYear(1600));
        
        }
        [Fact]
        public void isLeapYear_checks_0()
        {
            var program = new Program();
            var expected = false;
            Assert.Equal(expected, program.isLeapYear(0));
        }
        [Fact]
        public void IsLeapYear_checks_before_1582()
        {
            var program = new Program();
            var expected = false;
            Assert.Equal(expected, program.isLeapYear(400));
        }
    }
}
