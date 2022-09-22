using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationRegex
{
    public class Pattern
    {
        Regex regex = new Regex("^[A-Z]{1}[A-Za-z]{2,}$");
        Regex regex1 = new Regex("^[A-Za-z0-9+_.-]+@[a-zA-Z0-9.-]+$");
        Regex regex2 = new Regex("^[0-9]{2}[_][0-9]{10}$");


        public void ValidFirstName(string First_Name)
        {
            Console.WriteLine("Enter FirstName:" + First_Name);
            if (regex.IsMatch(First_Name))
            {
                Console.WriteLine("valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
        public void ValidLastName(string Last_Name)
        {
            Console.WriteLine("Enter LastName:" + Last_Name);
            if (regex.IsMatch(Last_Name))
            {
                Console.WriteLine("valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
        public void ValidEmail_Id(string Email_id)
        {
            Console.WriteLine("Enter Email.id:" + Email_id);
            if (regex1.IsMatch(Email_id))
            {
                Console.WriteLine("valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
        public void ValidPhoneNO(string Phone_No)
        {
            Console.WriteLine("Enter phoneNo:" + Phone_No);
            if (regex2.IsMatch(Phone_No))
            {
                Console.WriteLine("valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
    }
}
