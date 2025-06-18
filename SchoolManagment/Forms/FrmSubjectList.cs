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
    public partial class FrmSubjectList : Form
    {
        DBSchool db = new DBSchool();
        public FrmSubjectList()
        {
            InitializeComponent();
        }

        private void FrmSubjectList_Load(object sender, EventArgs e)
        {
            subjectBindingSource.DataSource = db.Subjects.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpsertSubject upsertSubject = new UpsertSubject(null);
            upsertSubject.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Subject s = subjectBindingSource.Current as Subject;
            UpsertSubject upsertSubject = new UpsertSubject(s);
            upsertSubject.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Subject s = subjectBindingSource.Current as Subject;
            subjectBindingSource.Remove(s);
            db.Subjects.Remove(s);
            db.SaveChanges();
        }
    }
}
