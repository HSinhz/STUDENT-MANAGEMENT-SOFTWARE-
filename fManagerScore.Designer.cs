namespace Project_Windows
{
    partial class fManagerScore
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFind = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbNameSubject = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtNameStudent = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAddScore = new System.Windows.Forms.Button();
            this.dt123 = new System.Windows.Forms.DataGridView();
            this.SubjectID123 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubjectName123 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentID123 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameStudent123 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Score123 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Score223 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit123 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt123)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(417, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ BẢNG ĐIỂM";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnFind);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(83, 123);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1030, 160);
            this.panel1.TabIndex = 1;
            // 
            // btnFind
            // 
            this.btnFind.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnFind.Location = new System.Drawing.Point(566, 27);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(106, 37);
            this.btnFind.TabIndex = 3;
            this.btnFind.Text = "Tìm kiếm";
            this.btnFind.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cbNameSubject);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(32, 79);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(528, 52);
            this.panel3.TabIndex = 2;
            // 
            // cbNameSubject
            // 
            this.cbNameSubject.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbNameSubject.FormattingEnabled = true;
            this.cbNameSubject.Location = new System.Drawing.Point(124, 11);
            this.cbNameSubject.Name = "cbNameSubject";
            this.cbNameSubject.Size = new System.Drawing.Size(389, 29);
            this.cbNameSubject.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(19, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên môn học";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtNameStudent);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(32, 21);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(528, 52);
            this.panel2.TabIndex = 0;
            // 
            // txtNameStudent
            // 
            this.txtNameStudent.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNameStudent.Location = new System.Drawing.Point(124, 11);
            this.txtNameStudent.Name = "txtNameStudent";
            this.txtNameStudent.Size = new System.Drawing.Size(389, 29);
            this.txtNameStudent.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(19, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên sinh viên";
            // 
            // btnClose
            // 
            this.btnClose.CausesValidation = false;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClose.Location = new System.Drawing.Point(1007, 60);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(106, 37);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Đóng";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAddScore
            // 
            this.btnAddScore.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddScore.Location = new System.Drawing.Point(115, 298);
            this.btnAddScore.Name = "btnAddScore";
            this.btnAddScore.Size = new System.Drawing.Size(106, 37);
            this.btnAddScore.TabIndex = 5;
            this.btnAddScore.Text = "Nhập điểm";
            this.btnAddScore.UseVisualStyleBackColor = true;
            this.btnAddScore.Click += new System.EventHandler(this.btnAddScore_Click);
            // 
            // dt123
            // 
            this.dt123.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt123.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SubjectID123,
            this.SubjectName123,
            this.StudentID123,
            this.NameStudent123,
            this.Score123,
            this.Score223,
            this.Edit123});
            this.dt123.Location = new System.Drawing.Point(96, 373);
            this.dt123.Name = "dt123";
            this.dt123.RowTemplate.Height = 25;
            this.dt123.Size = new System.Drawing.Size(1017, 419);
            this.dt123.TabIndex = 6;
            // 
            // SubjectID123
            // 
            this.SubjectID123.DataPropertyName = "SubjectID";
            this.SubjectID123.HeaderText = "SubjectID";
            this.SubjectID123.Name = "SubjectID123";
            // 
            // SubjectName123
            // 
            this.SubjectName123.DataPropertyName = "SubjectName";
            this.SubjectName123.HeaderText = "SubjectName";
            this.SubjectName123.Name = "SubjectName123";
            // 
            // StudentID123
            // 
            this.StudentID123.DataPropertyName = "StudentID";
            this.StudentID123.HeaderText = "StudentID";
            this.StudentID123.Name = "StudentID123";
            // 
            // NameStudent123
            // 
            this.NameStudent123.DataPropertyName = "NameStudent";
            this.NameStudent123.HeaderText = "NameStudent";
            this.NameStudent123.Name = "NameStudent123";
            // 
            // Score123
            // 
            this.Score123.DataPropertyName = "Score1";
            this.Score123.HeaderText = "Score1";
            this.Score123.Name = "Score123";
            // 
            // Score223
            // 
            this.Score223.DataPropertyName = "Score2";
            this.Score223.HeaderText = "Score2";
            this.Score223.Name = "Score223";
            // 
            // Edit123
            // 
            this.Edit123.HeaderText = "Edit";
            this.Edit123.Name = "Edit123";
            this.Edit123.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Edit123.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Edit123.Text = "Edit";
            this.Edit123.UseColumnTextForButtonValue = true;
            // 
            // fManagerScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 861);
            this.Controls.Add(this.dt123);
            this.Controls.Add(this.btnAddScore);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "fManagerScore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fManagerScore";
            this.Load += new System.EventHandler(this.fManagerScore_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt123)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Button btnFind;
        private Panel panel3;
        private ComboBox cbNameSubject;
        private Label label3;
        private Panel panel2;
        private TextBox txtNameStudent;
        private Label label2;
        private Button btnClose;
        private Button btnAddScore;
        private DataGridView dt123;
        private DataGridViewTextBoxColumn SubjectID123;
        private DataGridViewTextBoxColumn SubjectName123;
        private DataGridViewTextBoxColumn StudentID123;
        private DataGridViewTextBoxColumn NameStudent123;
        private DataGridViewTextBoxColumn Score123;
        private DataGridViewTextBoxColumn Score223;
        private DataGridViewButtonColumn Edit123;
    }
}