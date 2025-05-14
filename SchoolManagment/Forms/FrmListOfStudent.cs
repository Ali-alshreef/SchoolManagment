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
        public FrmListOfStudent()
        {
            InitializeComponent();
        }

        private void FrmListOfStudent_Load(object sender, EventArgs e)
        {
            List<Student> list = new List<Student>();
            Student student = new Student();
            student.Id = 1;
            student.FullName = "خالد";
            Student student2 = new Student();
            student2.Id = 2;
            student2.FullName = "احمد";
            list.Add(student);
            list.Add(student2);
            studentBindingSource.DataSource = list;

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            Student s = studentBindingSource.Current as Student;
         
            FrmUpsertStudent frmUpsertStudent = new FrmUpsertStudent(s);
            frmUpsertStudent.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Student s = studentBindingSource.Current as Student;
            FrmUpsertStudent frmUpsertStudent = new FrmUpsertStudent(s);
            frmUpsertStudent.ShowDialog();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
