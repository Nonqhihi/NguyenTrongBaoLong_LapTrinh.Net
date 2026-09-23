namespace bai4._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var courses = new[]
             {
                 new { Name = "Lập trình C#", Code = "CS" },
                 new { Name = "Lập trình Java", Code = "JAVA" },
                 new { Name = "Lập trình Python", Code = "PY" }
             };

            cboCourse.DataSource = courses;
            cboCourse.DisplayMember = "Name";
            cboCourse.ValueMember = "Code";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string phone = mtxtPhone.Text;
            string birthDate = dtpBirthDate.Value.ToString("dd/MM/yyyy");

            string course = cboCourse.Text;

            string gender = "";

            if (rdoMale.Checked)
                gender = "Nam";
            else if (rdoFemale.Checked)
                gender = "Nữ";

            string subjects = "";

            if (chkCSharp.Checked)
                subjects += "C#, ";

            if (chkJava.Checked)
                subjects += "Java, ";

            if (chkPython.Checked)
                subjects += "Python";

            MessageBox.Show(
                "THÔNG TIN ĐĂNG KÝ\n\n" +
                "Họ tên: " + name + "\n" +
                "Số điện thoại: " + phone + "\n" +
                "Ngày sinh: " + birthDate + "\n" +
                "Giới tính: " + gender + "\n" +
                "Khóa học: " + course + "\n" +
                "Môn học: " + subjects
            );
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
