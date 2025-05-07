using SchoolManagment.Data;
using SchoolManagment.Models;

namespace SchoolManagment.Forms
{
    public partial class FrmUpsertStudent : FrmBase
    {
        Student Student;
        DBSchool db = new DBSchool();
        public FrmUpsertStudent()
        {
            InitializeComponent();
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
            Activ(false);
            gernders.Add("ذكر");
            gernders.Add("أنثى");
            CBGenderType.DataSource = gernders;
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            Student = new Student();

            Activ(true);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Student.Id = Convert.ToInt16(txtId.Text);
                Student.FullName = txtFullName.Text;
                db.Students.Add(Student);
                Activ(false);
            }
            catch (Exception)
            {
                MessageBox.Show("يجب ادخال ارقام فقط");
            }
        }
    }
}
