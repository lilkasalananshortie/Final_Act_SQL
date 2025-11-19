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
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(
                    "SELECT FirstName, LastName, MiddleName, Age, Gender, Program " +
                    "FROM ClubMembers WHERE StudentID = @id", conn);

                cmd.Parameters.AddWithValue("@id", StudentIDCBox.SelectedItem.ToString());

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


        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            if (StudentIDCBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a Student ID first.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(
                    "UPDATE ClubMembers SET " +
                    "FirstName = @fname, " +
                    "LastName = @lname, " +
                    "MiddleName = @mname, " +
                    "Age = @age, " +
                    "Gender = @gender, " +
                    "Program = @program " +
                    "WHERE StudentID = @id", conn);

                cmd.Parameters.AddWithValue("@fname", FirstNameTxtBox.Text);
                cmd.Parameters.AddWithValue("@lname", LastNameTxtBox.Text);
                cmd.Parameters.AddWithValue("@mname", MiddleNameTxtBox.Text);
                cmd.Parameters.AddWithValue("@age", AgeTxtBox.Text);
                cmd.Parameters.AddWithValue("@gender", GenderTxtBox.Text);
                cmd.Parameters.AddWithValue("@program", ProgramTxtBox.Text);
                cmd.Parameters.AddWithValue("@id", StudentIDCBox.SelectedItem.ToString());

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Member information updated successfully!");
                }
                else
                {
                    MessageBox.Show("Update failed. No rows were affected.");
                }
            }
        }

    }
}
