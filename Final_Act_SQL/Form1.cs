using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Act_SQL
{

    public partial class FrmClubRegistration : Form
    {
        private ClubRegistrationQuery clubRegistrationQuery = new ClubRegistrationQuery();
        private int ID, Age, count;
        private long StudentID;
        private string FirstName, LastName, Gender, MiddleName, Program;

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            FrmUpdateMember frmUpdateMember = new FrmUpdateMember();
            frmUpdateMember.Show();
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            RefreshListoOfClubMembers();
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            ID = int.Parse(studentIDTxtBox.Text);
            StudentID = long.Parse(studentIDTxtBox.Text);
            FirstName = FirstNametxtBox.Text;
            MiddleName = MiddleTxtBox.Text;
            LastName = LastNameTxtBox.Text;
            Age = int.Parse(AgetxtBox.Text);
            Program = ProgramCBox.Text;
            Gender = GenderCBox.Text;


            clubRegistrationQuery.RegisterStudent(
                ID,
                StudentID,
                FirstName,
                MiddleName,
                LastName,
                Age,
                Program,
                Gender

                );

        }

        private void FrmClubRegistration_Load(object sender, EventArgs e)
        {
            FrmUpdateMember frmUpdateMember = new FrmUpdateMember();
            frmUpdateMember.Show(); 
        }

        public FrmClubRegistration()
        {
            InitializeComponent();
        }

        public void RegistrationID ()
        {
            count = clubRegistrationQuery.bindingSource.Count;
            ID = count + 1;
        }


        public void RefreshListoOfClubMembers()
        {
            clubRegistrationQuery.DisplayList();
            dataTable.DataSource = clubRegistrationQuery.bindingSource;
        }

    }
}
