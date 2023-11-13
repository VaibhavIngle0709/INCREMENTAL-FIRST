using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dotnetapp.Models;

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

                sqlcommand.Excecu



                

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        public void EditTeam(int TeamId)
        {

        }
        public void DeleteTeam(int TeamId)
        {

        }
        public void ListTeam()
        {
            
        }
    }
}
