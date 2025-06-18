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
    public partial class UpsertSubject : Form
    {
        DBSchool db = new DBSchool();
        Subject? subject;
        public UpsertSubject(Subject? s)
        {
            InitializeComponent();
            subject = s;
            if (subject == null)
            {
                subject = new Subject();
                db.Subjects.Add(subject);
            }
            else
            {
                subject = db.Subjects.Find(subject.Id);
            }
            subjectBindingSource.DataSource = subject;
        }

        private void UpsertSubject_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            db.SaveChanges();
        }
    }
}
