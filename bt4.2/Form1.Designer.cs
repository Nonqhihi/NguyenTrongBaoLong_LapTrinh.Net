namespace bai4._2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtName = new TextBox();
            mtxtPhone = new MaskedTextBox();
            dtpBirthDate = new DateTimePicker();
            cboCourse = new ComboBox();
            rdoMale = new RadioButton();
            rdoFemale = new RadioButton();
            chkCSharp = new CheckBox();
            chkJava = new CheckBox();
            chkPython = new CheckBox();
            btnRegister = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(317, 82);
            txtName.Name = "txtName";
            txtName.Size = new Size(125, 27);
            txtName.TabIndex = 0;
            // 
            // mtxtPhone
            // 
            mtxtPhone.Location = new Point(317, 125);
            mtxtPhone.Mask = "0000000000";
            mtxtPhone.Name = "mtxtPhone";
            mtxtPhone.Size = new Size(125, 27);
            mtxtPhone.TabIndex = 1;
            // 
            // dtpBirthDate
            // 
            dtpBirthDate.Format = DateTimePickerFormat.Short;
            dtpBirthDate.Location = new Point(317, 168);
            dtpBirthDate.Name = "dtpBirthDate";
            dtpBirthDate.Size = new Size(150, 27);
            dtpBirthDate.TabIndex = 2;
            // 
            // cboCourse
            // 
            cboCourse.FormattingEnabled = true;
            cboCourse.Location = new Point(316, 260);
            cboCourse.Name = "cboCourse";
            cboCourse.Size = new Size(151, 28);
            cboCourse.TabIndex = 3;
            // 
            // rdoMale
            // 
            rdoMale.AutoSize = true;
            rdoMale.Location = new Point(317, 216);
            rdoMale.Name = "rdoMale";
            rdoMale.Size = new Size(62, 24);
            rdoMale.TabIndex = 4;
            rdoMale.TabStop = true;
            rdoMale.Text = "Nam";
            rdoMale.UseVisualStyleBackColor = true;
            // 
            // rdoFemale
            // 
            rdoFemale.AutoSize = true;
            rdoFemale.Location = new Point(403, 216);
            rdoFemale.Name = "rdoFemale";
            rdoFemale.Size = new Size(50, 24);
            rdoFemale.TabIndex = 5;
            rdoFemale.TabStop = true;
            rdoFemale.Text = "Nữ";
            rdoFemale.UseVisualStyleBackColor = true;
            // 
            // chkCSharp
            // 
            chkCSharp.AutoSize = true;
            chkCSharp.Location = new Point(312, 301);
            chkCSharp.Name = "chkCSharp";
            chkCSharp.Size = new Size(49, 24);
            chkCSharp.TabIndex = 6;
            chkCSharp.Text = "C#";
            chkCSharp.UseVisualStyleBackColor = true;
            // 
            // chkJava
            // 
            chkJava.AutoSize = true;
            chkJava.Location = new Point(367, 301);
            chkJava.Name = "chkJava";
            chkJava.Size = new Size(59, 24);
            chkJava.TabIndex = 7;
            chkJava.Text = "Java";
            chkJava.UseVisualStyleBackColor = true;
            // 
            // chkPython
            // 
            chkPython.AutoSize = true;
            chkPython.Location = new Point(432, 301);
            chkPython.Name = "chkPython";
            chkPython.Size = new Size(76, 24);
            chkPython.TabIndex = 8;
            chkPython.Text = "Python";
            chkPython.UseVisualStyleBackColor = true;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(303, 361);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(139, 47);
            btnRegister.TabIndex = 9;
            btnRegister.Text = "Đăng ký";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(173, 9);
            label1.Name = "label1";
            label1.Size = new Size(397, 60);
            label1.TabIndex = 10;
            label1.Text = "Đăng Ký Học Viên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(171, 89);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 11;
            label2.Text = "Học Tên:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(171, 173);
            label3.Name = "label3";
            label3.Size = new Size(77, 20);
            label3.TabIndex = 12;
            label3.Text = "Ngày sinh:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(171, 132);
            label4.Name = "label4";
            label4.Size = new Size(39, 20);
            label4.TabIndex = 13;
            label4.Text = "SĐT:";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(173, 218);
            label5.Name = "label5";
            label5.Size = new Size(68, 20);
            label5.TabIndex = 14;
            label5.Text = "Giới tính:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(171, 263);
            label6.Name = "label6";
            label6.Size = new Size(74, 20);
            label6.TabIndex = 15;
            label6.Text = "Khóa học:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(175, 301);
            label7.Name = "label7";
            label7.Size = new Size(70, 20);
            label7.TabIndex = 16;
            label7.Text = "Môn học:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnRegister);
            Controls.Add(chkPython);
            Controls.Add(chkJava);
            Controls.Add(chkCSharp);
            Controls.Add(rdoFemale);
            Controls.Add(rdoMale);
            Controls.Add(cboCourse);
            Controls.Add(dtpBirthDate);
            Controls.Add(mtxtPhone);
            Controls.Add(txtName);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private MaskedTextBox mtxtPhone;
        private DateTimePicker dtpBirthDate;
        private ComboBox cboCourse;
        private RadioButton rdoMale;
        private RadioButton rdoFemale;
        private CheckBox chkCSharp;
        private CheckBox chkJava;
        private CheckBox chkPython;
        private Button btnRegister;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}
