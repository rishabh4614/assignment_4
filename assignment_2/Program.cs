using System;

namespace assignment_2
{
   /* Interfaces
-----------
 
1. Create a class library CalculateConcession()  that takes age as an input and calculates concession for travel as below:
If age<=5 then “Little Champs- Free Ticket” should be displayed
If age >60 then calculate 30% concession on the totalfare(Which is a constant Eg:500/-) and Display “ Senior Citizen” + Calculated Fare
Else “Print Ticket Booked” + Fare.
Create a Console application with a Class called Program which has TotalFare as Constant, Name, Age.Accept Name, Age from 
   the user and call the CalculateConcession() function
*/
    class Library
    {
        private const double Nfare = 500;
        private double Sfare = Nfare * 0.7;
        public void CalculateConcession(int age)
        {
            if (age <=5)
            {
                Console.WriteLine("Little Champs - Free Ticket");
            }else if(age > 60)
            {
                
                Console.WriteLine($"Senior Citizen Calculated Fare : {Sfare}");
            }
            else { Console.WriteLine($"Ticket Booked. Calculated Fare: {Nfare}"); }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Enter Name: ");
            string str = Console.ReadLine();
            Console.Write("Enter your age to book the ticket: ");
            int AGE = Convert.ToInt32(Console.ReadLine());
            Library l = new Library();
            l.CalculateConcession(AGE);
        }
    }
}
