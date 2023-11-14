using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dotnetapp.Models;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using dotnetapp.Managers;


namespace dotnetapp.Managers
{
    public class PlayerManager
    {
        // Write your fuctions here...
        // DisplayAllPlayers
        // AddPlayer
        // EditPlayer
        // DeletePlayer
        // ListPlayers
        // FindPlayer
        // DisplayAllPlayers
        private readonly string Connectionstring = "User ID=sa;password=examlyMssql@123; server=localhost;Database=IPLDB;trusted_connection=false;Persist Security Info=False;Encrypt=False";

        public void AddPlayerToDatabase(Player p)
        {
            SqlConnection con = new SqlConnection(Connectionstring);
            try
            {
                con.Open();
                string cmdtxt = "Insert into Players values (@Id,@Name,@Age,@Category,@BiddingPrice,@TeamId)";

                SqlCommand cmd = new SqlCommand(cmdtxt, con);

                cmd.Parameters.AddWithValue("@Id", p.Id);
                cmd.Parameters.AddWithValue("@Name", p.Name);
                cmd.Parameters.AddWithValue("@Age", p.Age);
                cmd.Parameters.AddWithValue("@Category", p.Category);
                cmd.Parameters.AddWithValue("@BiddingPrice", p.BiddingPrice);
                cmd.Parameters.AddWithValue("@TeamId", p.TeamId);
                cmd.ExecuteNonQuery();
                Console.WriteLine("PLAYER ADDED SUCCESSFULLY");
                Console.WriteLine("---------------------------------");
                Console.WriteLine("PRESS ENTER KEY TO CONTINUE");
                Console.ReadLine();

                Console.Clear();

                con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR WHILE ADDING PLAYER");
                Console.WriteLine(ex.Message);
            }

        }
        public void AddPlayer()
        {

        }
        public void EditPlayer(int id)
        {
            FindPlayer(id);

        }
        public void DeletePlayer(int id)
        {
            SqlConnection con = new SqlConnection(Connectionstring);
            try
            {
                Console.Clear();

                FindPlayer(id);
                Console.Write("ARE YOU SURE YOU WANT TO DELETE THIS RECORD (Y/N): ");
                char choice = char.Parse(Console.ReadLine());
                if (choice == 'y')
                {
                    con.Open();

                    string cmdtxt = "Delete from Players where Id=@Id";

                    SqlCommand cmd = new SqlCommand(cmdtxt, con);

                    cmd.Parameters.AddWithValue("@Id", id);

                    cmd.ExecuteNonQuery();

                    Console.WriteLine("DELETED SUCCESSFULLY");

                    con.Close();
                }



            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR WHILE DELETING ALL PLAYER");
                Console.WriteLine(ex.Message);
            }

        }
        
        public void ListPlayersOfParticularTeam(int TeamId)
        {
            SqlConnection con =new SqlConnection(Connectionstring);
            try
            {
                string cmdtxt="Select * from players where TeamId=@TeamId";
                

            }
            catch(Exception ex)
            {
                Console.WriteLine("ERROR WHILE DISPLAYING PARTICULAR TEAM PLAYER.");
                Console.WriteLine(ex.Message);
            }
        }
        public void ListPlayers()
        {
            DisplayAllPlayers();
        }
        public void FindPlayer(int id)
        {
            SqlConnection con = new SqlConnection(Connectionstring);
            string cmdtxt = "Select * from Players where Id=@Id";
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(cmdtxt, con);
                cmd.Parameters.AddWithValue("@Id", id);
                SqlDataReader reader = cmd.ExecuteReader();

                Console.WriteLine("DETAILS OF PLAYER");
                Console.WriteLine("---------------------");
                Console.WriteLine("ID    NAME                            AGE    CATEGORY    BIDDING PRICE    TEAMID");
                Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - -");

                if (reader.Read())
                {
                    Console.WriteLine($"{reader["Id"]}     {reader["Name"]}                           {reader["Age"]}     {reader["Category"]}     {reader["BiddingPrice"]}        {reader["TeamId"]}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR WHILE DISPLAYING ALL PLAYER");
                Console.WriteLine(ex.Message);
            }
        }



        public Player getPlayerReady()
        {
            Console.Clear();
            Player p = new Player();
            Console.WriteLine("ADDING PLAYER TO DATABASE");
            Console.WriteLine("---------------------------");
            Console.WriteLine();

            Console.Write("ENTER  UNIQUE [ PLAYER ID ] : ");
            p.Id = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Write("ENTER PLAYER [ NAME ] : ");
            p.Name = Console.ReadLine();
            Console.WriteLine();

            Console.Write("ENTER PLAYER [ AGE ] : ");
            p.Age = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Write("ENTER PLAYER [ CATEGORY ] : ");
            p.Category = Console.ReadLine();
            Console.WriteLine();

            Console.Write("ENTER PLAYER [ BIDDING PRICE ] : ");
            p.BiddingPrice = decimal.Parse(Console.ReadLine());
            Console.WriteLine();

            TeamManager tm = new TeamManager();
            tm.ListTeam();
            Console.Write("ENTER PLAYER [ TEAM ID ] WITH REFERENCE TO ABOVE TABLE : ");
            p.TeamId = int.Parse(Console.ReadLine());

            Console.Clear();

            return p;

        }

        public void DisplayAllPlayers()
        {
            Console.Clear();
            SqlConnection con = new SqlConnection(Connectionstring);
            try
            {
                con.Open();
                string cmdtxt = "Select * from Players";

                SqlCommand cmd = new SqlCommand(cmdtxt, con);

                SqlDataReader reader = cmd.ExecuteReader();

                Console.Clear();
                Console.WriteLine("ALL PLAYERS");
                Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - -");
                Console.WriteLine("ID    NAME                            AGE    CATEGORY    BIDDING PRICE    TEAMID");
                Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - -");


                while (reader.Read())
                {
                    Console.WriteLine($"{reader["Id"]}     {reader["Name"]}                           {reader["Age"]}     {reader["Category"]}     {reader["BiddingPrice"]}        {reader["TeamId"]}");
                }
                Console.WriteLine("PRESS ENTER KEY TO CONTINUE.");
                Console.ReadLine();
                Console.Clear();
                con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR WHILE DISPLAYING ALL PLAYER");
                Console.WriteLine(ex.Message);
            }
        }


    }
}
