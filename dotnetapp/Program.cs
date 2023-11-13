using System;
using System.Collections.Generic;
using System.Linq;
using dotnetapp.Managers;

namespace dotnetapp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create instances of managers    
            Console.WriteLine("Welcome To IPL Bidding");
            Console.WriteLine("1.Team Management.");
            Console.WriteLine("2.Player Management."); 
            Console.Write("Select You Choice: ");
            int choice =int.Parse(Console.ReadLine());   
            if(choice==1)
            {

            }
            else if(choice==2)
            {

            }
            else
            {
                Console.WriteLine("Invalid Choice");
            }
        }
    }
}
