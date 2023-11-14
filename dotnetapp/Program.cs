using System;
using System.Collections.Generic;
using System.Linq;
using dotnetapp.Managers;
using dotnetapp.Models;
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
                Console.Clear();
                Console.WriteLine("PLAYER MANAGEMENT");
                Console.WriteLine("1.ADD PLAYER.");
                Console.WriteLine("2.FIND PLAYER.");
                Console.WriteLine("3.EDIT PLAYER.");
                Console.WriteLine("4.DELETE PLAYER.");
                Console.WriteLine("5.LIST PLAYER OF PARTICULAR TEAM.");
                Console.WriteLine("6.DISPLAY ALL PLAYER.");
                Console.WriteLine("----------------------------------------------------");
                Console.Write("ENTER YOUR CHOICE : ");
                int playerchoice= int.Parse( Console.ReadLine());
                switch(playerchoice)
                {
                    case 1:
                    Player p=new Player
                    {
                      Id=1,
                      Name="Dhoni",
                      Age=40,
                      Category="CAPTAIN",
                      BiddingPrice=9000000.13m,
                      TeamId=1
                    };
                    playerManager.AddPlayerToDatabase(p);
                    break;
                    case 2:
                    break;
                    case 3:
                    break;
                    case 4:
                    break;
                    case 5:
                    break;
                    case 6:
                    break;
                    default:
                    break;
                }
            }
            else
            {
                Console.WriteLine("Invalid Choice");
            }
            Console.Clear();
        }
    }
}
