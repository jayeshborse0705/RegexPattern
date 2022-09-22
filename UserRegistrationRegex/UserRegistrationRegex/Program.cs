using System;
namespace UserRegistrationRegex
{
    class Program
    {
        public static void Main(String[] args)
        {
            Pattern paterns = new Pattern();
            Console.WriteLine("Enter First Name:");
            string firstName = Console.ReadLine();
            paterns.ValidFirstName(firstName);

            Console.WriteLine("Enter Last Name:");
            string LastName = Console.ReadLine();
            paterns.ValidLastName(LastName);

            Console.WriteLine("Enter Email_id:");
            string Email_id = Console.ReadLine();
            paterns.ValidEmail_Id(Email_id);
        }
    }
}