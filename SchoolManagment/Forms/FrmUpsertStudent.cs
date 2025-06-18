using SchoolManagment.Data;
using SchoolManagment.Models;
using System.Windows.Forms;

namespace SchoolManagment.Forms
{
    public partial class FrmUpsertStudent : FrmBase
    {
        Student? Student;
        DBSchool db = new DBSchool();
        public FrmUpsertStudent(Student student)
        {
            InitializeComponent();
            Student = student;
            if (student == null)
            {
                Student = new Student();
                db.Students.Add(Student);
            }
            else
            {
                Student = db.Students.Find(student.Id);
            }
            studentBindingSource.DataSource = Student;
        }

        List<string> gernders = new List<string>();

        void Activ(bool c)
        {
            txtId.Enabled = c;
            txtFullName.Enabled = c;
            DTPBithDate.Enabled = c;
            CBGenderType.Enabled = c;
        }

        private void FrmUpsertStudent_Load(object sender, EventArgs e)
        {
            if (Student == null)
            {
                Activ(false);
            }
            else
            {
                txtFullName.Text = Student.FullName;

                Activ(true);
            }

            gernders.Add("ذكر");
            gernders.Add("أنثى");
            CBGenderType.DataSource = gernders;
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            Activ(true);
            btnSave.Enabled = true;
            btnNew.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtFullName.Text)
                    || string.IsNullOrWhiteSpace(txtFullName.Text))
                {
                    MessageBox.Show("الاسم فارغ");
                    return;
                }

               
                db.SaveChanges();
                Activ(false);
                btnSave.Enabled = false;
                btnNew.Enabled = true;
                MessageBox.Show("تم الحفظ");
            }
            catch (Exception)
            {
                MessageBox.Show("يجب ادخال ارقام فقط");
            }
        }

        private void txtId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtFullName.Focus();
            }
        }
        private void txtId_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtFullName.Focus();
            }
        }
        private void txtFullName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DTPBithDate.Focus();
            }
        }

       
    }
}
