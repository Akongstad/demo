using System;

namespace assignment0
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var program = new Program();
            Console.WriteLine("Please provide a year to see if it is a leap year. Confirm with [Enter]");
            
            
            String input = Console.ReadLine();
            try{
                int year = Convert.ToInt32(input);
                 if(program.isLeapYear(year)){
                    Console.WriteLine("yay");
                } else {
                    Console.WriteLine("nay");
                }
            } catch(Exception e){
                Console.WriteLine('"' + input + '"' + " Is not a valid year!");
            }
        }
    
        public bool isLeapYear(int year){
            if(year < 1582){
                return false;
            }
            if(year %100 == 0 && year %400 != 0){
                return false;
            }
            if(year % 400 == 0){
                return true;
            }
            if (year % 4 == 0){
                return true;
            }
                return false;
        }
    }
}
