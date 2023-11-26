using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class LoginForm : Form
    {
 
        public LoginForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          /*  this.Hide();
            string password = "23";
            if (password == this.ToString())
            {
                Cats form = new Cats();
                form.Show();
                this.Hide();
            } */

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*  string str = textBox1.Text;
              Person person = new Person(str);
              person.AddUsersCats("barsik");
              person.AddUsersCats("murzilka");
              person.ShowCats();
              listBox1.Items.Add(str); */
            string password = "23";
            if (password == textBox1.Text)
            {
                listBox1.Items.Add(password);
                //kthis.Hide();
            }
        }
        
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
