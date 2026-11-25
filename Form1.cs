using System.Windows.Forms.VisualStyles;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {

        List<Student> students;

        public Form1()
        {
            InitializeComponent();

            students = new List<Student>();


            students.Add(new Student("student 1", [7, 4, 9]));
            students.Add(new Student("student 2", [5, 4, 4]));
            students.Add(new Student("student 3", [4, 4, 4]));
            students.Add(new Student("student 4", [4, 6, 6]));


            object[] data = new object[4];

            for (int i = 0; i < students.Capacity; i++)
            {
                data[i] = students[i].name_surname;
            }

            listBox1.Items.AddRange(data);

        }

        private void button1_Click(object sender, EventArgs e)
        {



            int _textBox1 = Convert.ToInt32(textBox1.Text);
            int _textBox2 = Convert.ToInt32(textBox2.Text);
            int _textBox3 = Convert.ToInt32(textBox3.Text);

            double average = (_textBox1 + _textBox2 + _textBox3) / 3;

            label4.Text = average.ToString();
        }

        private void button1_Click(object sender, MouseEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            string selected_value = (string)((ListBox)sender).SelectedItem;


            Student student = null;

            for (int i = 0; i < students.Capacity; i++)
            {
                if (students[i].name_surname.Equals(selected_value))
                {
                    student = students[i];
                    break;
                }
            }


            decimal sum = 0;

            for (int i = 0; i < student.grades.Capacity; i++)
            {

                sum += student.grades[i];
           
            }
            label6.Text =  (sum/ student.grades.Capacity).ToString();

        }
    }
}
