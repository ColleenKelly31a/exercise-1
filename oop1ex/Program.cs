using System;

namespace oop1ex
{
    internal class Program
    {
       

        static void Main(string[] args)
        {
            //Accepting user input
            Console.WriteLine("Enter your first name:");
            //setting it in variable Firstname
            string firstName = Console.ReadLine();

            
            Console.WriteLine("Enter your last name:");
            string lastName = Console.ReadLine(); //set() is called to assign value

            
            Console.WriteLine("Please enter the date you were born in the format DD/MM/YYYYY: ");
           
            DateTime dateOfBirth = DateTime.Parse(Console.ReadLine());
           
            //creating an object p of Person class passing it arguments
            Person p = new Person(firstName, lastName, dateOfBirth);
             
            Console.Clear();
            

            //accessing the getters in the properties
            //and printing them using object p
            Console.WriteLine($"\nYour full name is {p.FirstName} {p.LastName} and you were born on a {p.DateOfBirth.DayOfWeek.ToString()} .");
            
            Console.ReadKey();
        }
    }
}
