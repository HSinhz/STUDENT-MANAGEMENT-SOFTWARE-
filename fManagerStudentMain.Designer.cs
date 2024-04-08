namespace Project_Windows
{
    partial class fManagerStudentMain
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
            this.btnClose = new System.Windows.Forms.Button();
            this.cbClass = new System.Windows.Forms.ComboBox();
            this.cbBranch = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnAddSV = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.StudentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameStudent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SexStudent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddressStudent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BirthDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.IDStudent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone123 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email123 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDBranch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDClass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit123 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.View123 = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClose.Location = new System.Drawing.Point(1119, 56);
            this.btnClose.Name = "btnClose";
            this.btnClose.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnClose.Size = new System.Drawing.Size(64, 41);
            this.btnClose.TabIndex = 20;
            this.btnClose.Text = "Đóng";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cbClass
            // 
            this.cbClass.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbClass.FormattingEnabled = true;
            this.cbClass.Location = new System.Drawing.Point(139, 273);
            this.cbClass.Name = "cbClass";
            this.cbClass.Size = new System.Drawing.Size(240, 29);
            this.cbClass.TabIndex = 19;
            this.cbClass.SelectedIndexChanged += new System.EventHandler(this.cbClass_SelectedIndexChanged);
            // 
            // cbBranch
            // 
            this.cbBranch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbBranch.FormattingEnabled = true;
            this.cbBranch.Location = new System.Drawing.Point(141, 218);
            this.cbBranch.Name = "cbBranch";
            this.cbBranch.Size = new System.Drawing.Size(238, 29);
            this.cbBranch.TabIndex = 18;
            this.cbBranch.SelectedIndexChanged += new System.EventHandler(this.cbBranch_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(-105, 319);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 21);
            this.label4.TabIndex = 17;
            this.label4.Text = "Lớp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(-105, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 21);
            this.label3.TabIndex = 16;
            this.label3.Text = "Ngành";
            // 
            // txtStudentName
            // 
            this.txtStudentName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtStudentName.Location = new System.Drawing.Point(139, 149);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(240, 29);
            this.txtStudentName.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(-105, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 21);
            this.label2.TabIndex = 14;
            this.label2.Text = "Tên sinh viên";
            // 
            // btnFind
            // 
            this.btnFind.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnFind.Location = new System.Drawing.Point(404, 142);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(64, 41);
            this.btnFind.TabIndex = 13;
            this.btnFind.Text = "Tìm";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnAddSV
            // 
            this.btnAddSV.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddSV.Location = new System.Drawing.Point(34, 65);
            this.btnAddSV.Name = "btnAddSV";
            this.btnAddSV.Size = new System.Drawing.Size(146, 41);
            this.btnAddSV.TabIndex = 12;
            this.btnAddSV.Text = "Thêm sinh viên";
            this.btnAddSV.UseVisualStyleBackColor = true;
            this.btnAddSV.Click += new System.EventHandler(this.btnAddSV_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(380, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 45);
            this.label1.TabIndex = 11;
            this.label1.Text = "Quản lý sinh viên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(34, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 21);
            this.label5.TabIndex = 23;
            this.label5.Text = "Lớp";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(34, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 21);
            this.label6.TabIndex = 22;
            this.label6.Text = "Ngành";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(34, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 21);
            this.label7.TabIndex = 21;
            this.label7.Text = "Tên sinh viên";
            // 
            // StudentID
            // 
            this.StudentID.DataPropertyName = "StudentID";
            this.StudentID.HeaderText = "StudentID";
            this.StudentID.Name = "StudentID";
            // 
            // NameStudent
            // 
            this.NameStudent.DataPropertyName = "NameStudent";
            this.NameStudent.HeaderText = "NameStudent";
            this.NameStudent.Name = "NameStudent";
            // 
            // SexStudent
            // 
            this.SexStudent.DataPropertyName = "SexStudent";
            this.SexStudent.HeaderText = "SexStudent";
            this.SexStudent.Name = "SexStudent";
            // 
            // AddressStudent
            // 
            this.AddressStudent.DataPropertyName = "AddressStudent";
            this.AddressStudent.HeaderText = "AddressStudent";
            this.AddressStudent.Name = "AddressStudent";
            // 
            // BirthDay
            // 
            this.BirthDay.DataPropertyName = "BirthDay";
            this.BirthDay.HeaderText = "BirthDay";
            this.BirthDay.Name = "BirthDay";
            // 
            // Phone
            // 
            this.Phone.DataPropertyName = "Phone";
            this.Phone.HeaderText = "Phone";
            this.Phone.Name = "Phone";
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDStudent,
            this.StudentName,
            this.Sex,
            this.StudentAddress,
            this.dataGridViewTextBoxColumn1,
            this.Phone123,
            this.Email123,
            this.IDBranch,
            this.IDClass,
            this.Edit123,
            this.View123});
            this.dataGridView1.Location = new System.Drawing.Point(34, 340);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(1149, 437);
            this.dataGridView1.TabIndex = 24;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // IDStudent
            // 
            this.IDStudent.DataPropertyName = "StudentID";
            this.IDStudent.HeaderText = "StudentID";
            this.IDStudent.Name = "IDStudent";
            // 
            // StudentName
            // 
            this.StudentName.DataPropertyName = "NameStudent";
            this.StudentName.HeaderText = "NameStudent";
            this.StudentName.Name = "StudentName";
            // 
            // Sex
            // 
            this.Sex.DataPropertyName = "SexStudent";
            this.Sex.HeaderText = "StudentSex";
            this.Sex.Name = "Sex";
            // 
            // StudentAddress
            // 
            this.StudentAddress.DataPropertyName = "AddressStudent";
            this.StudentAddress.HeaderText = "AddressStudent";
            this.StudentAddress.Name = "StudentAddress";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "BirthDay";
            this.dataGridViewTextBoxColumn1.HeaderText = "BirthDay";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // Phone123
            // 
            this.Phone123.DataPropertyName = "Phone";
            this.Phone123.HeaderText = "Phone";
            this.Phone123.Name = "Phone123";
            // 
            // Email123
            // 
            this.Email123.DataPropertyName = "Email";
            this.Email123.HeaderText = "Email";
            this.Email123.Name = "Email123";
            // 
            // IDBranch
            // 
            this.IDBranch.DataPropertyName = "BranchID";
            this.IDBranch.HeaderText = "BranchID";
            this.IDBranch.Name = "IDBranch";
            // 
            // IDClass
            // 
            this.IDClass.DataPropertyName = "ClassID";
            this.IDClass.HeaderText = "ClassID";
            this.IDClass.Name = "IDClass";
            // 
            // Edit123
            // 
            this.Edit123.HeaderText = "Edit";
            this.Edit123.Name = "Edit123";
            this.Edit123.Text = "Sua";
            this.Edit123.UseColumnTextForButtonValue = true;
            // 
            // View123
            // 
            this.View123.HeaderText = "View";
            this.View123.Name = "View123";
            this.View123.Text = "Xem";
            this.View123.UseColumnTextForButtonValue = true;
            // 
            // fManagerStudentMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 789);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.cbClass);
            this.Controls.Add(this.cbBranch);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtStudentName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.btnAddSV);
            this.Controls.Add(this.label1);
            this.Name = "fManagerStudentMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fManagerStudentMain";
            this.Activated += new System.EventHandler(this.fManagerStudentMain_Activated);
            this.Load += new System.EventHandler(this.fManagerStudentMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnClose;
        private ComboBox cbClass;
        private ComboBox cbBranch;
        private Label label4;
        private Label label3;
        private TextBox txtStudentName;
        private Label label2;
        private Button btnFind;
        private Button btnAddSV;
        private Label label1;
        private Label label5;
        private Label label6;
        private Label label7;
        private DataGridViewTextBoxColumn StudentID;
        private DataGridViewTextBoxColumn NameStudent;
        private DataGridViewTextBoxColumn SexStudent;
        private DataGridViewTextBoxColumn AddressStudent;
        private DataGridViewTextBoxColumn BirthDay;
        private DataGridViewTextBoxColumn Phone;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewButtonColumn View;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn IDStudent;
        private DataGridViewTextBoxColumn StudentName;
        private DataGridViewTextBoxColumn Sex;
        private DataGridViewTextBoxColumn StudentAddress;
        private DataGridViewTextBoxColumn Phone123;
        private DataGridViewTextBoxColumn Email123;
        private DataGridViewTextBoxColumn IDBranch;
        private DataGridViewTextBoxColumn IDClass;
        private DataGridViewButtonColumn Edit123;
        private DataGridViewButtonColumn View123;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    }
}