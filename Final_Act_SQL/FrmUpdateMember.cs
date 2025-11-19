using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Final_Act_SQL
{
    public partial class FrmUpdateMember : Form
    {
        string connectionString = "Data Source=LAB-A-PC00;Initial Catalog=ClubDbMhaku;User ID=manalili.m;Password=12345;";
        string query = "SELECT StudentID FROM ClubMembers"; 

        public FrmUpdateMember()
        {
            InitializeComponent();
            LoadStudentIDs(); 
        }

        private void LoadStudentIDs()
        {
            using (SqlConnection sqlConnect = new SqlConnection(connectionString))
            {
                using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnect))
                {
                    sqlConnect.Open();
                    using (SqlDataReader reader = sqlCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            StudentIDCBox.Items.Add(reader["StudentID"].ToString());
                        }
                    }
                }
            }



        }

        private void StudentIDCBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection("Data Source=LAB-A-PC00;Initial Catalog=ClubDbMhaku;User ID=manalili.m;Password=12345;"))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT FirstName, LastName, Age, Gender, Program FROM ClubMembers WHERE StudentId = @id", conn);
                cmd.Parameters.AddWithValue("@id", StudentIDCBox);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    FirstNameTxtBox.Text = reader["FirstName"].ToString();
                    LastNameTxtBox.Text = reader["LastName"].ToString();
                    MiddleNameTxtBox.Text = reader["MiddleName"].ToString();
                    AgeTxtBox.Text = reader["Age"].ToString();
                    GenderTxtBox.Text = reader["Gender"].ToString();
                    ProgramTxtBox.Text = reader["Program"].ToString();
                }
            }
        }
    }
}
