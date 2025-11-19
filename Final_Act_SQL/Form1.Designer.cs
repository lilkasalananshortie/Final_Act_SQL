namespace Final_Act_SQL
{
    partial class FrmClubRegistration
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.FormPanel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dataTable = new System.Windows.Forms.DataGridView();
            this.RegisterBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.RefreshBtn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.studentIDTxtBox = new System.Windows.Forms.TextBox();
            this.LastNameTxtBox = new System.Windows.Forms.TextBox();
            this.FirstNametxtBox = new System.Windows.Forms.TextBox();
            this.MiddleTxtBox = new System.Windows.Forms.TextBox();
            this.AgetxtBox = new System.Windows.Forms.TextBox();
            this.GenderCBox = new System.Windows.Forms.ComboBox();
            this.ProgramCBox = new System.Windows.Forms.ComboBox();
            this.FormPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student ID: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(282, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "First Name: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(529, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Middle Name: ";
            // 
            // FormPanel
            // 
            this.FormPanel.Controls.Add(this.ProgramCBox);
            this.FormPanel.Controls.Add(this.GenderCBox);
            this.FormPanel.Controls.Add(this.AgetxtBox);
            this.FormPanel.Controls.Add(this.MiddleTxtBox);
            this.FormPanel.Controls.Add(this.FirstNametxtBox);
            this.FormPanel.Controls.Add(this.LastNameTxtBox);
            this.FormPanel.Controls.Add(this.studentIDTxtBox);
            this.FormPanel.Controls.Add(this.label9);
            this.FormPanel.Controls.Add(this.label7);
            this.FormPanel.Controls.Add(this.label6);
            this.FormPanel.Controls.Add(this.label5);
            this.FormPanel.Controls.Add(this.label3);
            this.FormPanel.Controls.Add(this.label4);
            this.FormPanel.Controls.Add(this.label1);
            this.FormPanel.Controls.Add(this.label2);
            this.FormPanel.Location = new System.Drawing.Point(12, 12);
            this.FormPanel.Name = "FormPanel";
            this.FormPanel.Size = new System.Drawing.Size(859, 350);
            this.FormPanel.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(579, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 29);
            this.label5.TabIndex = 4;
            this.label5.Text = "Program: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 29);
            this.label6.TabIndex = 5;
            this.label6.Text = "Age: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(220, 217);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 29);
            this.label7.TabIndex = 6;
            this.label7.Text = "Gender: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(22, 365);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(240, 29);
            this.label8.TabIndex = 7;
            this.label8.Text = "List of Club Members";
            // 
            // dataTable
            // 
            this.dataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTable.Location = new System.Drawing.Point(12, 397);
            this.dataTable.Name = "dataTable";
            this.dataTable.Size = new System.Drawing.Size(869, 242);
            this.dataTable.TabIndex = 8;
            // 
            // RegisterBtn
            // 
            this.RegisterBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterBtn.Location = new System.Drawing.Point(899, 28);
            this.RegisterBtn.Name = "RegisterBtn";
            this.RegisterBtn.Size = new System.Drawing.Size(141, 50);
            this.RegisterBtn.TabIndex = 9;
            this.RegisterBtn.Text = "Register";
            this.RegisterBtn.UseVisualStyleBackColor = true;
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateBtn.Location = new System.Drawing.Point(899, 103);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(141, 50);
            this.UpdateBtn.TabIndex = 10;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefreshBtn.Location = new System.Drawing.Point(899, 397);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(141, 50);
            this.RefreshBtn.TabIndex = 11;
            this.RefreshBtn.Text = "Refresh";
            this.RefreshBtn.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(361, 161);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 29);
            this.label9.TabIndex = 7;
            // 
            // studentIDTxtBox
            // 
            this.studentIDTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentIDTxtBox.Location = new System.Drawing.Point(15, 58);
            this.studentIDTxtBox.Name = "studentIDTxtBox";
            this.studentIDTxtBox.Size = new System.Drawing.Size(193, 29);
            this.studentIDTxtBox.TabIndex = 8;
            // 
            // LastNameTxtBox
            // 
            this.LastNameTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameTxtBox.Location = new System.Drawing.Point(15, 161);
            this.LastNameTxtBox.Name = "LastNameTxtBox";
            this.LastNameTxtBox.Size = new System.Drawing.Size(212, 29);
            this.LastNameTxtBox.TabIndex = 9;
            // 
            // FirstNametxtBox
            // 
            this.FirstNametxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNametxtBox.Location = new System.Drawing.Point(263, 161);
            this.FirstNametxtBox.Name = "FirstNametxtBox";
            this.FirstNametxtBox.Size = new System.Drawing.Size(219, 29);
            this.FirstNametxtBox.TabIndex = 10;
            // 
            // MiddleTxtBox
            // 
            this.MiddleTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MiddleTxtBox.Location = new System.Drawing.Point(534, 161);
            this.MiddleTxtBox.Name = "MiddleTxtBox";
            this.MiddleTxtBox.Size = new System.Drawing.Size(217, 29);
            this.MiddleTxtBox.TabIndex = 11;
            // 
            // AgetxtBox
            // 
            this.AgetxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgetxtBox.Location = new System.Drawing.Point(15, 261);
            this.AgetxtBox.Name = "AgetxtBox";
            this.AgetxtBox.Size = new System.Drawing.Size(157, 29);
            this.AgetxtBox.TabIndex = 12;
            // 
            // GenderCBox
            // 
            this.GenderCBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenderCBox.FormattingEnabled = true;
            this.GenderCBox.Location = new System.Drawing.Point(225, 258);
            this.GenderCBox.Name = "GenderCBox";
            this.GenderCBox.Size = new System.Drawing.Size(169, 32);
            this.GenderCBox.TabIndex = 13;
            // 
            // ProgramCBox
            // 
            this.ProgramCBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProgramCBox.FormattingEnabled = true;
            this.ProgramCBox.Location = new System.Drawing.Point(584, 48);
            this.ProgramCBox.Name = "ProgramCBox";
            this.ProgramCBox.Size = new System.Drawing.Size(234, 32);
            this.ProgramCBox.TabIndex = 14;
            // 
            // FrmClubRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 651);
            this.Controls.Add(this.RefreshBtn);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.RegisterBtn);
            this.Controls.Add(this.dataTable);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.FormPanel);
            this.Name = "FrmClubRegistration";
            this.Text = "FrmClubRegistration";
            this.FormPanel.ResumeLayout(false);
            this.FormPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel FormPanel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataTable;
        private System.Windows.Forms.Button RegisterBtn;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button RefreshBtn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox ProgramCBox;
        private System.Windows.Forms.ComboBox GenderCBox;
        private System.Windows.Forms.TextBox AgetxtBox;
        private System.Windows.Forms.TextBox MiddleTxtBox;
        private System.Windows.Forms.TextBox FirstNametxtBox;
        private System.Windows.Forms.TextBox LastNameTxtBox;
        private System.Windows.Forms.TextBox studentIDTxtBox;
    }
}

