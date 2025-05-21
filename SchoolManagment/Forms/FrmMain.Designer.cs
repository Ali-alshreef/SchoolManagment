namespace SchoolManagment.Forms
{
    partial class FrmMain
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
            menuStrip1 = new MenuStrip();
            الطلابToolStripMenuItem = new ToolStripMenuItem();
            MnuStudentAdd = new ToolStripMenuItem();
            mnuListOfStudent = new ToolStripMenuItem();
            الموادالدراسيةToolStripMenuItem = new ToolStripMenuItem();
            إضافةمادةToolStripMenuItem = new ToolStripMenuItem();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            checkBox1 = new CheckBox();
            button4 = new Button();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            checkBox2 = new CheckBox();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { الطلابToolStripMenuItem, الموادالدراسيةToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(8, 2, 0, 2);
            menuStrip1.Size = new Size(962, 40);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // الطلابToolStripMenuItem
            // 
            الطلابToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { MnuStudentAdd, mnuListOfStudent });
            الطلابToolStripMenuItem.Image = Properties.Resources.person;
            الطلابToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            الطلابToolStripMenuItem.Name = "الطلابToolStripMenuItem";
            الطلابToolStripMenuItem.Size = new Size(86, 36);
            الطلابToolStripMenuItem.Text = "الطلاب";
            // 
            // MnuStudentAdd
            // 
            MnuStudentAdd.Image = Properties.Resources.personeAdd;
            MnuStudentAdd.ImageScaling = ToolStripItemImageScaling.None;
            MnuStudentAdd.Name = "MnuStudentAdd";
            MnuStudentAdd.Size = new Size(154, 38);
            MnuStudentAdd.Text = "إضافة طالب";
            MnuStudentAdd.Click += MnuStudentAdd_Click;
            // 
            // mnuListOfStudent
            // 
            mnuListOfStudent.Image = Properties.Resources.personsearch;
            mnuListOfStudent.ImageScaling = ToolStripItemImageScaling.None;
            mnuListOfStudent.Name = "mnuListOfStudent";
            mnuListOfStudent.Size = new Size(154, 38);
            mnuListOfStudent.Text = "قائمة الطلاب";
            mnuListOfStudent.Click += mnuListOfStudent_Click;
            // 
            // الموادالدراسيةToolStripMenuItem
            // 
            الموادالدراسيةToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { إضافةمادةToolStripMenuItem });
            الموادالدراسيةToolStripMenuItem.Name = "الموادالدراسيةToolStripMenuItem";
            الموادالدراسيةToolStripMenuItem.Size = new Size(91, 36);
            الموادالدراسيةToolStripMenuItem.Text = "المواد الدراسية";
            // 
            // إضافةمادةToolStripMenuItem
            // 
            إضافةمادةToolStripMenuItem.Name = "إضافةمادةToolStripMenuItem";
            إضافةمادةToolStripMenuItem.Size = new Size(129, 22);
            إضافةمادةToolStripMenuItem.Text = "إضافة مادة";
            // 
            // button1
            // 
            button1.Location = new Point(424, 86);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(854, 210);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 2;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Cursor = Cursors.Hand;
            button3.Location = new Point(499, 240);
            button3.Name = "button3";
            button3.Size = new Size(135, 85);
            button3.TabIndex = 3;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            button3.MouseLeave += button3_MouseLeave;
            button3.MouseHover += button3_MouseHover;
            // 
            // textBox1
            // 
            textBox1.CharacterCasing = CharacterCasing.Upper;
            textBox1.Location = new Point(121, 86);
            textBox1.MaxLength = 1000;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(257, 24);
            textBox1.TabIndex = 4;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            textBox2.CharacterCasing = CharacterCasing.Upper;
            textBox2.Location = new Point(576, 210);
            textBox2.MaxLength = 1000;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(257, 24);
            textBox2.TabIndex = 5;
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(67, 342);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(102, 20);
            checkBox1.TabIndex = 6;
            checkBox1.Text = "checkBox1";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(216, 342);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 7;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(50, 214);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(119, 20);
            radioButton1.TabIndex = 8;
            radioButton1.TabStop = true;
            radioButton1.Text = "radioButton1";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(216, 214);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(122, 20);
            radioButton2.TabIndex = 9;
            radioButton2.TabStop = true;
            radioButton2.Text = "radioButton2";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(67, 289);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(105, 20);
            checkBox2.TabIndex = 10;
            checkBox2.Text = "checkBox2";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(9F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(962, 449);
            Controls.Add(checkBox2);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(button4);
            Controls.Add(checkBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(5, 3, 5, 3);
            MaximizeBox = false;
            Name = "FrmMain";
            Text = "FrmMain";
            WindowState = FormWindowState.Maximized;
            FormClosing += FrmMain_FormClosing;
            Load += FrmMain_Load;
            Click += FrmMain_Click;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem الطلابToolStripMenuItem;
        private ToolStripMenuItem MnuStudentAdd;
        private ToolStripMenuItem الموادالدراسيةToolStripMenuItem;
        private ToolStripMenuItem إضافةمادةToolStripMenuItem;
        private ToolStripMenuItem mnuListOfStudent;
        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox textBox1;
        private TextBox textBox2;
        private CheckBox checkBox1;
        private Button button4;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private CheckBox checkBox2;
    }
}