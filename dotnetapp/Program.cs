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
            Console.WriteLine("WELCOME TO IPL BIDDING");
            Console.WriteLine("1.TEAM MANAGEMENT.");
            Console.WriteLine("2.PLAYER MANAGEMENT."); 
            Console.Write("SELECT YOUR CHOICE: ");
            int choice =int.Parse(Console.ReadLine());   
            if(choice==1)
            {
                Console.WriteLine("TEAM MANAGEMENT");
                Console.WriteLine("1.CREATE TEAM");
                Console.WriteLine("2.EDIT TEAM");
                Console.WriteLine("3.DELETE TEAM");
                Console.WriteLine("4.LIST TEAM");
                Console.Write("ENTER YOU CHOICE");
                int teamchoice=int.Parse(Console.ReadLine());
                TeamManager teamManager=new TeamManager();
                switch(teamchoice)
                {
                    case 1:
                    teamManager.CreateTeam();
                    break;

                    case 2:
                    teamManager.
                    
                }



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
