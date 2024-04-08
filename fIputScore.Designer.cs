namespace Project_Windows
{
    partial class fIputScore
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtScore2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtScore1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbNameStudent = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbNameSubject = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(16, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(593, 492);
            this.panel1.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.CausesValidation = false;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClose.Location = new System.Drawing.Point(450, 418);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(116, 52);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Hủy";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSave.Location = new System.Drawing.Point(320, 418);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(116, 52);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txtScore2);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Location = new System.Drawing.Point(321, 184);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(245, 52);
            this.panel5.TabIndex = 6;
            // 
            // txtScore2
            // 
            this.txtScore2.Location = new System.Drawing.Point(121, 17);
            this.txtScore2.Name = "txtScore2";
            this.txtScore2.Size = new System.Drawing.Size(100, 23);
            this.txtScore2.TabIndex = 2;
            this.txtScore2.Validating += new System.ComponentModel.CancelEventHandler(this.txtScore2_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(19, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "Điểm cuối kì";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtScore1);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(48, 184);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(245, 52);
            this.panel4.TabIndex = 5;
            // 
            // txtScore1
            // 
            this.txtScore1.Location = new System.Drawing.Point(141, 17);
            this.txtScore1.Name = "txtScore1";
            this.txtScore1.Size = new System.Drawing.Size(100, 23);
            this.txtScore1.TabIndex = 1;
            this.txtScore1.Validating += new System.ComponentModel.CancelEventHandler(this.txtScore1_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(19, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Điểm thường kì";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbNameStudent);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(38, 82);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(528, 52);
            this.panel2.TabIndex = 4;
            // 
            // cbNameStudent
            // 
            this.cbNameStudent.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbNameStudent.FormattingEnabled = true;
            this.cbNameStudent.Location = new System.Drawing.Point(124, 14);
            this.cbNameStudent.Name = "cbNameStudent";
            this.cbNameStudent.Size = new System.Drawing.Size(389, 29);
            this.cbNameStudent.TabIndex = 2;
            this.cbNameStudent.Validating += new System.ComponentModel.CancelEventHandler(this.cbNameStudent_Validating);
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
            // panel3
            // 
            this.panel3.Controls.Add(this.cbNameSubject);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(38, 24);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(528, 52);
            this.panel3.TabIndex = 3;
            // 
            // cbNameSubject
            // 
            this.cbNameSubject.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbNameSubject.FormattingEnabled = true;
            this.cbNameSubject.Location = new System.Drawing.Point(124, 11);
            this.cbNameSubject.Name = "cbNameSubject";
            this.cbNameSubject.Size = new System.Drawing.Size(389, 29);
            this.cbNameSubject.TabIndex = 1;
            this.cbNameSubject.SelectedIndexChanged += new System.EventHandler(this.cbNameSubject_SelectedIndexChanged);
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
            // fIputScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 524);
            this.Controls.Add(this.panel1);
            this.Name = "fIputScore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fIputScore";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fIputScore_FormClosing);
            this.Load += new System.EventHandler(this.fIputScore_Load);
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private ComboBox cbNameSubject;
        private Label label3;
        private Panel panel5;
        private Label label4;
        private Panel panel4;
        private Label label1;
        private Panel panel2;
        private Label label2;
        private Panel panel6;
        private Label lbTotal;
        private Label label5;
        private Button btnClose;
        private Button btnSave;
        private ToolTip toolTip1;
        private ComboBox cbNameStudent;
        private TextBox txtScore2;
        private TextBox txtScore1;
    }
}