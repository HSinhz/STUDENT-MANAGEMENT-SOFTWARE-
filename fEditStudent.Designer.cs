namespace Project_Windows
{
    partial class fEditStudent
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.txtAddressStudent = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.cbBranch = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.cbClass = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.dtBirthDay = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtSex = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtNameStudent = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel11);
            this.panel1.Controls.Add(this.panel10);
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Controls.Add(this.panel9);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(12, 124);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1049, 607);
            this.panel1.TabIndex = 2;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.txtAddressStudent);
            this.panel11.Controls.Add(this.label10);
            this.panel11.Location = new System.Drawing.Point(19, 256);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(846, 50);
            this.panel11.TabIndex = 3;
            // 
            // txtAddressStudent
            // 
            this.txtAddressStudent.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAddressStudent.Location = new System.Drawing.Point(141, 11);
            this.txtAddressStudent.Name = "txtAddressStudent";
            this.txtAddressStudent.Size = new System.Drawing.Size(686, 29);
            this.txtAddressStudent.TabIndex = 1;
            this.txtAddressStudent.Validating += new System.ComponentModel.CancelEventHandler(this.txtAddressStudent_Validating);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(19, 14);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 21);
            this.label10.TabIndex = 0;
            this.label10.Text = "Địa chỉ";
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.btnCancel);
            this.panel10.Controls.Add(this.btnSave);
            this.panel10.Location = new System.Drawing.Point(565, 485);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(454, 82);
            this.panel10.TabIndex = 7;
            // 
            // btnCancel
            // 
            this.btnCancel.CausesValidation = false;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancel.Location = new System.Drawing.Point(252, 16);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(109, 48);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSave.Location = new System.Drawing.Point(50, 16);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(109, 48);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.cbBranch);
            this.panel8.Controls.Add(this.label8);
            this.panel8.Location = new System.Drawing.Point(569, 140);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(454, 50);
            this.panel8.TabIndex = 6;
            // 
            // cbBranch
            // 
            this.cbBranch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbBranch.FormattingEnabled = true;
            this.cbBranch.Location = new System.Drawing.Point(141, 11);
            this.cbBranch.Name = "cbBranch";
            this.cbBranch.Size = new System.Drawing.Size(301, 29);
            this.cbBranch.TabIndex = 1;
            this.cbBranch.Validating += new System.ComponentModel.CancelEventHandler(this.cbBranch_Validating);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(19, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 21);
            this.label8.TabIndex = 0;
            this.label8.Text = "Ngành";
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.cbClass);
            this.panel9.Controls.Add(this.label9);
            this.panel9.Location = new System.Drawing.Point(569, 200);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(454, 50);
            this.panel9.TabIndex = 6;
            // 
            // cbClass
            // 
            this.cbClass.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbClass.FormattingEnabled = true;
            this.cbClass.Location = new System.Drawing.Point(141, 11);
            this.cbClass.Name = "cbClass";
            this.cbClass.Size = new System.Drawing.Size(301, 29);
            this.cbClass.TabIndex = 2;
            this.cbClass.Validating += new System.ComponentModel.CancelEventHandler(this.cbClass_Validating);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(19, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 21);
            this.label9.TabIndex = 0;
            this.label9.Text = "Lớp";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.dtBirthDay);
            this.panel7.Controls.Add(this.label7);
            this.panel7.Location = new System.Drawing.Point(19, 77);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(534, 50);
            this.panel7.TabIndex = 6;
            // 
            // dtBirthDay
            // 
            this.dtBirthDay.CalendarFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtBirthDay.CustomFormat = "dd/MM/yy";
            this.dtBirthDay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtBirthDay.Location = new System.Drawing.Point(141, 13);
            this.dtBirthDay.Name = "dtBirthDay";
            this.dtBirthDay.Size = new System.Drawing.Size(200, 23);
            this.dtBirthDay.TabIndex = 1;
            this.dtBirthDay.Validating += new System.ComponentModel.CancelEventHandler(this.dtBirthDay_Validating);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(19, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 21);
            this.label7.TabIndex = 0;
            this.label7.Text = "Ngày sinh";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.txtEmail);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Location = new System.Drawing.Point(19, 200);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(534, 50);
            this.panel6.TabIndex = 5;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEmail.Location = new System.Drawing.Point(141, 11);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(363, 29);
            this.txtEmail.TabIndex = 1;
            this.txtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmail_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(19, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 21);
            this.label6.TabIndex = 0;
            this.label6.Text = "Email";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txtPhone);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Location = new System.Drawing.Point(19, 140);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(534, 50);
            this.panel5.TabIndex = 4;
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPhone.Location = new System.Drawing.Point(141, 11);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(363, 29);
            this.txtPhone.TabIndex = 1;
            this.txtPhone.Validating += new System.ComponentModel.CancelEventHandler(this.txtPhone_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(17, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "Số điện thoại";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtSex);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(569, 21);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(215, 50);
            this.panel4.TabIndex = 3;
            // 
            // txtSex
            // 
            this.txtSex.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSex.Location = new System.Drawing.Point(121, 11);
            this.txtSex.Name = "txtSex";
            this.txtSex.Size = new System.Drawing.Size(81, 29);
            this.txtSex.TabIndex = 1;
            this.txtSex.Validating += new System.ComponentModel.CancelEventHandler(this.txtSex_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(19, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "Giới tính";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtNameStudent);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(19, 21);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(534, 50);
            this.panel3.TabIndex = 2;
            // 
            // txtNameStudent
            // 
            this.txtNameStudent.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNameStudent.Location = new System.Drawing.Point(141, 11);
            this.txtNameStudent.Name = "txtNameStudent";
            this.txtNameStudent.Size = new System.Drawing.Size(363, 29);
            this.txtNameStudent.TabIndex = 1;
            this.txtNameStudent.Validating += new System.ComponentModel.CancelEventHandler(this.txtNameStudent_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(19, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên sinh viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(415, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 45);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cập nhật thông tin ";
            // 
            // fEditStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 743);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "fEditStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cập nhật thông tin sinh viên";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fEditStudent_FormClosing);
            this.Load += new System.EventHandler(this.fEditStudent_Load);
            this.panel1.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Panel panel11;
        private TextBox txtAddressStudent;
        private Label label10;
        private Panel panel10;
        private Button btnCancel;
        private Button btnSave;
        private Panel panel8;
        private ComboBox cbBranch;
        private Label label8;
        private Panel panel9;
        private ComboBox cbClass;
        private Label label9;
        private Panel panel7;
        private DateTimePicker dtBirthDay;
        private Label label7;
        private Panel panel6;
        private TextBox txtEmail;
        private Label label6;
        private Panel panel5;
        private TextBox txtPhone;
        private Label label5;
        private Panel panel4;
        private TextBox txtSex;
        private Label label4;
        private Panel panel3;
        private TextBox txtNameStudent;
        private Label label3;
        private Label label1;
        private ToolTip toolTip1;
    }
}