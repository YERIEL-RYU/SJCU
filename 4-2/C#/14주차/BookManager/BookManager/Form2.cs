using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookManager
{
    public partial class Form2 : Form
    {
        public BindingSource? form1_bindingSource = null;
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string author = textBox1.Text;
            string title = textBox2.Text;
            int year = int.Parse(textBox3.Text);

            form1_bindingSource.Add(new Book(author, title, year));

            Close();
        }
    }
}
