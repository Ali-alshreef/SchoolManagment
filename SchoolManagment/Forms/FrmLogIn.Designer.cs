namespace SchoolManagment.Forms
{
    partial class FrmLogIn
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
            txtUserName = new TextBox();
            label1 = new Label();
            btnLogIn = new Button();
            label2 = new Label();
            txtPassWord = new TextBox();
            SuspendLayout();
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(196, 48);
            txtUserName.Name = "txtUserName";
            txtUserName.PlaceholderText = "Enter Your User Name";
            txtUserName.Size = new Size(198, 23);
            txtUserName.TabIndex = 0;
            txtUserName.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 51);
            label1.Name = "label1";
            label1.Size = new Size(153, 15);
            label1.TabIndex = 1;
            label1.Text = "إسم او رقم المستخدم";
            // 
            // btnLogIn
            // 
            btnLogIn.Cursor = Cursors.Hand;
            btnLogIn.FlatAppearance.BorderColor = Color.White;
            btnLogIn.FlatAppearance.BorderSize = 0;
            btnLogIn.FlatAppearance.MouseDownBackColor = Color.White;
            btnLogIn.FlatAppearance.MouseOverBackColor = Color.White;
            btnLogIn.FlatStyle = FlatStyle.Flat;
            btnLogIn.Image = Properties.Resources.login64;
            btnLogIn.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogIn.Location = new Point(409, 57);
            btnLogIn.Name = "btnLogIn";
            btnLogIn.Size = new Size(100, 56);
            btnLogIn.TabIndex = 2;
            btnLogIn.Text = "دخول";
            btnLogIn.TextAlign = ContentAlignment.MiddleRight;
            btnLogIn.UseVisualStyleBackColor = true;
            btnLogIn.Click += btnLogIn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(71, 98);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 4;
            label2.Text = "الباسوورد";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtPassWord
            // 
            txtPassWord.Location = new Point(196, 95);
            txtPassWord.Name = "txtPassWord";
            txtPassWord.PasswordChar = '*';
            txtPassWord.PlaceholderText = "enter Your PassWord";
            txtPassWord.Size = new Size(198, 23);
            txtPassWord.TabIndex = 3;
            txtPassWord.TextAlign = HorizontalAlignment.Center;
            // 
            // FrmLogIn
            // 
            AutoScaleDimensions = new SizeF(9F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(575, 158);
            Controls.Add(label2);
            Controls.Add(txtPassWord);
            Controls.Add(btnLogIn);
            Controls.Add(label1);
            Controls.Add(txtUserName);
            Font = new Font("29LT Bukra", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4, 3, 4, 3);
            Name = "FrmLogIn";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "شاشة تسجيل الدخول";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUserName;
        private Label label1;
        private Button btnLogIn;
        private Label label2;
        private TextBox txtPassWord;
    }
}