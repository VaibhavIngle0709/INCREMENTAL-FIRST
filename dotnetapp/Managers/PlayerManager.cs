using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dotnetapp.Models;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


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
        private readonly string Connectionstring="User ID=sa;password=examlyMssql@123; server=localhost;Database=IPLDB;trusted_connection=false;Persist Security Info=False;Encrypt=False";

        public void AddPlayerToDatabase(Player p)
        {
            SqlConnection con=new SqlConnection(Connectionstring);
            try
            {
             con.Open();
             string cmdtxt="Insert into Players values (@Id,@Name,@Age,@Category,@BiddingPrice,@TeamId)";
             
             SqlCommand cmd=new SqlCommand(cmdtxt,con);
             
             cmd.Parameters.AddWithValue("@Id",p.Id);
             cmd.Parameters.AddWithValue("@Name",p.Name);
             cmd.Parameters.AddWithValue("@Age",p.Age);
             cmd.Parameters.AddWithValue("@Category",p.Category);
             cmd.Parameters.AddWithValue("@BiddingPrice",p.BiddingPrice);
             cmd.Parameters.AddWithValue("@TeamId",p.TeamId);
             cmd.ExecuteNonQuery();
             Console.WriteLine("PLAYER ADDED SUCCESSFULLY");
             Console.WriteLine("---------------------------------");             
             Console.WriteLine("PRESS ENTER KEY TO CONTINUE");
             Console.ReadLine();

             Console.Clear();

             con.Close();
            }
            catch(Exception ex)
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

        }
        public void DeletePlayer(int id)
        {

        }
         public void ListPlayers()
        {
            
        }
        public void FindPlayer(int id)
        {

        }
        public void DisplayAllPlayers()
        {
            SqlConnection con =new SqlConnection(Connectionstring);
        }


    }
}
