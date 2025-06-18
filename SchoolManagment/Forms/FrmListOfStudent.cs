using SchoolManagment.Data;
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
    public partial class FrmListOfStudent : FrmBase
    {
        DBSchool db = new DBSchool();
        public FrmListOfStudent()
        {
            InitializeComponent();
        }

        private void FrmListOfStudent_Load(object sender, EventArgs e)
        {
            studentBindingSource.DataSource = db.Students.ToList();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            Student s = studentBindingSource.Current as Student;

            FrmUpsertStudent frmUpsertStudent = new FrmUpsertStudent(s);
            frmUpsertStudent.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var s = studentBindingSource.Current as Student;
            FrmUpsertStudent frmUpsertStudent = new FrmUpsertStudent(s);
            frmUpsertStudent.ShowDialog();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            FrmUpsertStudent frmUpsertStudent = new FrmUpsertStudent(null);
            frmUpsertStudent.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // DialogResult result = MessageBox.Show(
            //                    "Are you sure you want to delete this item?",
            //                    "Confirm Delete",
            //                    MessageBoxButtons.YesNo,
            //                    MessageBoxIcon.Warning);

            ////if (result == DialogResult.No)
            //// {

            //// }
            if (MessageBox.Show("هل متأكد من الحذف", "11", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Student s = studentBindingSource.Current as Student;
                studentBindingSource.Remove(s);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DBSchool dbR = new DBSchool();
            studentBindingSource.DataSource = dbR.Students.ToList();
        }

        private void btnAddInThreeTables_Click(object sender, EventArgs e)
        {
            City c = new City();
            c.Name = "زليتن";
            Subject s = new Subject();
            s.SubjectName = "رياضيات";
            Student st = new Student();
            st.FullName = "علي";
            st.BirthDate = DateTime.Now.AddYears(-30);
            db.Cities.Add(c);
            db.Subjects.Add(s);
            db.Students.Add(st);
            db.SaveChanges();
        }
    }
}
