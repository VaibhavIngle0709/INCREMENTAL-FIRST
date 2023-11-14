using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dotnetapp.Models;

using System.Data.SqlClient;


namespace dotnetapp.Managers
{
    public class TeamManager
    {
        // Write your functions here...
        // CreateTeam
        // UpdateTeam
        // DeleteTeam
        // ListTeams
        private readonly string Connectionstring="User ID=sa;password=examlyMssql@123; server=localhost;Database=IPLDB;trusted_connection=false;Persist Security Info=False;Encrypt=False";

        public void CreateTeam()
        {
            try
            {
                SqlConnection con=new SqlConnection(Connectionstring);
                con.Open();
                Console.Clear();
                Console.WriteLine("CREATING NEW TEAM");
                Console.Write("ENTER [TEAM ID]   : ");
                int teamid=int.Parse(Console.ReadLine());
                Console.Write("ENTER [TEAM NAME] : ");
                string teamname=Console.ReadLine();

                string cmdtext="Insert into Teams values(@TeamId,@TeamName)";
                SqlCommand sqlcommand=new SqlCommand(cmdtext,con);

                sqlcommand.Parameters.AddWithValue("@TeamId",teamid);
                sqlcommand.Parameters.AddWithValue("@TeamName",teamname);

                sqlcommand.ExecuteNonQuery();

                con.Close();
                

            }
            catch(Exception ex)
            {
                Console.WriteLine("ERROR WHILE CREATING TEAM");
                Console.WriteLine(ex.Message);
            }

        }
        public void EditTeam(int TeamId)
        { 
            SqlConnection con =new SqlConnection(Connectionstring);
            try
            {
                con.Open();
                //retrive team details
                string cmdtxt1="Select TeamName from Teams where TeamId=@TeamId";
                SqlCommand cmd1=new SqlCommand(cmdtxt1,con);
                cmd1.Parameters.AddWithValue("@TeamId",TeamId);

                Object resultName=cmd1.ExecuteScalar();
                Console.Clear();
                Console.WriteLine("--------------------------------");
                Console.WriteLine("TEAM YOU WANT TO EDIT");
                Console.WriteLine("--------------------------------");
                Console.WriteLine($"TEAM ID [ {TeamId} ] TEAM NAME [ {resultName.ToString()} ] :");
                Console.WriteLine("");

                Console.Write("ENTER NEW [ TEAM NAME ] :");
                string tname=Console.ReadLine();
                
                string cmdtxt2="alter table "

                con.Close();

            }
            catch(Exception ex)
            {
                Console.WriteLine("ERROR WHILE EDITING TEAM");
                Console.WriteLine(ex.Message);
            }
            

        }
        public void DeleteTeam(int TeamId)
        {
            
        }
        public void ListTeam()
        {
            SqlConnection con=new SqlConnection(Connectionstring);
            con.Open();

            string cmdtext="Select * from Teams";

            SqlCommand cmd=new SqlCommand(cmdtext,con);
            
            SqlDataReader dataReader=cmd.ExecuteReader();
                Console.WriteLine("");
                Console.WriteLine("- - - - - - - - - - - - - ");
                Console.WriteLine("TEAM ID         TEAM NAME");
            while(dataReader.Read())
            {
                Console.WriteLine($"{dataReader["TeamId"]}               {dataReader["TeamName"]}");
            }
         
                Console.WriteLine("- - - - - - - - - - - - - ");
                   Console.WriteLine("");

            con.Close();

            
        }
    }
}
