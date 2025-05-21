using SchoolManagment.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SchoolManagment.Forms
{
    public partial class FrmMain : FrmBase //Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        FrmUpsertStudent frmUpsertStudent;
        private void MnuStudentAdd_Click(object sender, EventArgs e)
        {
            frmUpsertStudent = new FrmUpsertStudent(null);
            frmUpsertStudent.Text = "11111111111";
            frmUpsertStudent.Show();
        }

        private void mnuListOfStudent_Click(object sender, EventArgs e)
        {
            FrmListOfStudent frmListOfStudent = new FrmListOfStudent();
            frmListOfStudent.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /// textBox1.SelectAll();
            //textBox1.Select(0,5);
            //textBox1.Copy();
            Clipboard.SetText(textBox1.Text);
            //textBox1.Select(1, 3);
            //string s = textBox1.Text.Substring(0, 3);
            //textBox1.Cut();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            textBox2.Text = Clipboard.GetText();
        }

        private void FrmMain_Click(object sender, EventArgs e)
        {
            if (this.BackColor == Color.Red)
            {
                this.BackColor = Color.White;
            }
            else if (this.BackColor == Color.White)
            {
                this.BackColor = Color.Red;
            }
            else
            {
                this.BackColor = Color.White;
            }

        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (MessageBox.Show("هل متأكد من الخروج", "11", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            //{

            //}
            //else
            //{
            //    return;
            //}
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            button3.BackColor = Color.Blue;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackColor = Color.Red;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bool c = checkBox1.Checked;
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
        }
    }
}
