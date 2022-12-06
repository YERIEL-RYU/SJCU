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
    public partial class Form3 : Form
    {
        public BindingSource? form1_bindingSource = null;
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string author = textBox1.Text;

            List<Book> booklist = (List<Book>)(form1_bindingSource.DataSource);

            var output = from item in booklist
                         where item.Author == author
                         orderby item.Year descending
                         select item;
            if (output.Count() > 0)
            {
                dataGridView1.DataSource = output.ToList();
                dataGridView1.Columns[0].HeaderText = "저자";
                dataGridView1.Columns[1].HeaderText = "제목";
                dataGridView1.Columns[2].HeaderText = "연도";
                dataGridView1.Update();
            }
            else
            {
                dataGridView1.DataSource = null;
                dataGridView1.Update();
                MessageBox.Show("검색 결과가 없습니다.");
            }
        }
    }
}
