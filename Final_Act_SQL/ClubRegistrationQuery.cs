using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Final_Act_SQL
{
    internal class ClubRegistrationQuery
    {
        private SqlCommand sqlCommand;
        private SqlConnection sqlConnect;
        private SqlDataReader sqlReader;
        private SqlDataAdapter sqlAdapter;

        private string connectionString;
        private DataTable dataTable;
        private BindingSource bindingSource;

        public string _FirstName, _MiddleName, _LastName, _Gender, _Program;
        public string _Age;


        public ClubRegistrationQuery()
        {
            connectionString = "Data Source=LAB-A-PC00;Initial Catalog=ClubDbMhaku;User ID=manalili.m;Password=***********;Trust Server Certificate=True";
            sqlConnect = new SqlConnection(connectionString);
            dataTable = new DataTable();
            bindingSource = new BindingSource();
        }

   
        public bool DisplayList()
        {
            string ViewClubMembers =
                "SELECT StudentId, FirstName, MiddleName, LastName, Age, Gender, Program " +
                "FROM ClubMembers";

            sqlAdapter = new SqlDataAdapter(ViewClubMembers, sqlConnect);

            dataTable.Clear();
            sqlAdapter.Fill(dataTable);
            bindingSource.DataSource = dataTable;

            return true;
        }

      
        public bool RegisterStudent(int ID, long StudentID, string FirstName, string MiddleName,
                                    string LastName, int Age, string Gender, string Program)
        {
            string query =
                "INSERT INTO ClubMembers (ID, StudentID, FirstName, MiddleName, LastName, Age, Gender, Program) " +
                "VALUES (@ID, @StudentID, @FirstName, @MiddleName, @LastName, @Age, @Gender, @Program)";

            sqlCommand = new SqlCommand(query, sqlConnect);

            sqlCommand.Parameters.Add("@ID", SqlDbType.Int).Value = ID;
            sqlCommand.Parameters.Add("@StudentID", SqlDbType.BigInt).Value = StudentID;
            sqlCommand.Parameters.Add("@FirstName", SqlDbType.VarChar).Value = FirstName;
            sqlCommand.Parameters.Add("@MiddleName", SqlDbType.VarChar).Value = MiddleName;
            sqlCommand.Parameters.Add("@LastName", SqlDbType.VarChar).Value = LastName;
            sqlCommand.Parameters.Add("@Age", SqlDbType.Int).Value = Age;
            sqlCommand.Parameters.Add("@Gender", SqlDbType.VarChar).Value = Gender;
            sqlCommand.Parameters.Add("@Program", SqlDbType.VarChar).Value = Program;

            sqlConnect.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnect.Close();

            return true;
        }
    }
}
