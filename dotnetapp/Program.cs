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
                char check='d';
                while()
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
                    //need to take input for teamId
                    teamManager.EditTeam();
                    break;
                    
                    case 3:
                    //need to take input for teamID
                    teamManager.DeleteTeam();
                    break;

                    case 4:
                    teamManager.ListTeam();
                    break;

                    default:
                    Console.Write("PLEASE SELECT A VALID CHOICE AND TRY AGAIN. PRESS (Y/N) : ");
                    //take input for Y/N here
                    break;

                    
                }
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
