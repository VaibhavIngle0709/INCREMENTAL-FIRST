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
            TeamManager teamManager=new TeamManager();
            PlayerManager playerManager=new PlayerManager();

            Console. Clear();  
            Console.WriteLine("WELCOME TO IPL BIDDING");
            Console.WriteLine("1.TEAM MANAGEMENT.");
            Console.WriteLine("2.PLAYER MANAGEMENT."); 
            Console.Write("SELECT YOUR CHOICE: ");
            int choice =int.Parse(Console.ReadLine());   
            if(choice==1)
            {
                char check='y';
                while(check=='y')
                {
                Console. Clear();
                Console.WriteLine("TEAM MANAGEMENT");
                Console.WriteLine("1.CREATE TEAM");
                Console.WriteLine("2.EDIT TEAM");
                Console.WriteLine("3.DELETE TEAM");
                Console.WriteLine("4.LIST TEAM");
                Console.Write("ENTER YOUR CHOICE : ");
                int teamchoice=int.Parse(Console.ReadLine());
            
                switch(teamchoice)
                {
                    case 1:
                    teamManager.CreateTeam();
                    break;

                    case 2:
                    //need to take input for teamId
                    Console.Write("PLEASE ENTER [TEAM ID] OF THE TEAM TO EDIT : ");
                    int idE=int.Parse(Console.ReadLine());
                    teamManager.EditTeam(idE);
                    break;
                    
                    case 3:
                    //need to take input for teamID
                    Console.Write("PLEASE ENTER [TEAM ID] OF THE TEAM TO DELETE : ");
                    int idD=int.Parse(Console.ReadLine());
                    teamManager.DeleteTeam(idD);
                    break;

                    case 4:
                    teamManager.ListTeam();
                    break;

                    default:
                    Console.WriteLine("PLEASE SELECT A VALID CHOICE AND TRY AGAIN.");
                    break;

                    
                }

                Console.Write("PRESS (Y/N) : ");
                    //take input for Y/N here
                 check=char.Parse(Console.ReadLine());
                }



            }
            else if(choice==2)
            {

            }
            else
            {
                Console.WriteLine("Invalid Choice");
            }
            Console.Clear();
        }
    }
}
