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
            MnuStudentAdd.Size = new Size(196, 38);
            MnuStudentAdd.Text = "إضافة طالب";
            MnuStudentAdd.Click += MnuStudentAdd_Click;
            // 
            // mnuListOfStudent
            // 
            mnuListOfStudent.Image = Properties.Resources.personsearch;
            mnuListOfStudent.ImageScaling = ToolStripItemImageScaling.None;
            mnuListOfStudent.Name = "mnuListOfStudent";
            mnuListOfStudent.Size = new Size(196, 38);
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
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(9F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(962, 449);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(5, 3, 5, 3);
            Name = "FrmMain";
            Text = "FrmMain";
            WindowState = FormWindowState.Maximized;
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
    }
}