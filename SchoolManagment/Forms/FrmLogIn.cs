using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagment.Forms
{
    public partial class FrmLogIn : Form
    {
        public FrmLogIn()
        {
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            if(txtUserName.Text == "1" && txtPassWord.Text == "1")
            {
                this.Hide();
                FrmMain frmMain = new FrmMain();
                frmMain.Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password");
            }
        }
    }
}
