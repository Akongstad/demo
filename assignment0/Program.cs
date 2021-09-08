using System;

namespace assignment0
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //int input = Console.ReadLine();
            //if(isLeapYear){
                
            //}
        }
    
        public bool isLeapYear(int year){
            if(year == 0){
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