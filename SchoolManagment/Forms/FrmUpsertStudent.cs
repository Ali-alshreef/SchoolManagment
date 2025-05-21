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

                Student.Id = Convert.ToInt16(txtId.Text);
                Student.FullName = txtFullName.Text;
                Student.BirthDate = DTPBithDate.Value;
                db.Students.Add(Student);
                Activ(false);
                btnSave.Enabled = false;
                btnNew.Enabled = true;
            }
            catch (Exception)
            {
                MessageBox.Show("يجب ادخال ارقام فقط");
            }
        }
    }
}
