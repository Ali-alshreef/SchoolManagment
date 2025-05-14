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

namespace SchoolManagment.Forms
{
    public partial class FrmMain : FrmBase //Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void MnuStudentAdd_Click(object sender, EventArgs e)
        {
            FrmUpsertStudent frmUpsertStudent = new FrmUpsertStudent(null);
            frmUpsertStudent.ShowDialog();
        }

        private void mnuListOfStudent_Click(object sender, EventArgs e)
        {
            FrmListOfStudent frmListOfStudent = new FrmListOfStudent();
            frmListOfStudent.ShowDialog();
        }
    }
}
