using System.Xml.Linq;

namespace AddressBook
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string email = textBox2.Text;
            string phone = textBox3.Text;

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(phone))
            {
                MessageBox.Show("Please enter all fields.");
                return;
            }

            string entry = $"Name: {name}, Email: {email}, Phone: {phone}";
            listBox1.Items.Add(entry);

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }
    }
}
