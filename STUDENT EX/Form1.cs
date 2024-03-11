using System.Diagnostics.Contracts;

namespace STUDENT_EX
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void namefield_TextChanged(object sender, EventArgs e)
        {
        }

        private void lastnamefield_TextChanged(object sender, EventArgs e)
        {
        }

        private void mlastnamefield_TextChanged(object sender, EventArgs e)
        {
        }
        List<Student> list = new List<Student>(capacity: 20);
        Student x;
        String fulldata;
        private void buttonaddstudent_Click(object sender, EventArgs e)
        {
            x = new Student();
            x.Name = namefield.Text;
            namefield.Clear();
            x.LastName = lastnamefield.Text;
            lastnamefield.Clear();
            x.MlastName = mlastnamefield.Text;
            mlastnamefield.Clear();
            x.Birthday = Convert.ToDateTime(textBoxbirthday.Text);
            textBoxbirthday.Clear();
            x.Id = textBoxID.Text;
            textBoxID.Clear();
            x.Career = textBoxcareer.Text;
            textBoxcareer.Clear();
            x.Grade = Convert.ToDouble(textBoxgrade.Text);
            textBoxgrade.Clear();
            fulldata = x.ToString();
            list.Add(x);
            String datalist = "";
            foreach (Student ac in list)
            {
                datalist += ac + "\r\n";
            }
            textBoxdata.Text = datalist;
        }

        private void textBoxdata_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBoxbirthday_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBoxID_TextChanged(object sender, EventArgs e)
        {
        }
    }
}