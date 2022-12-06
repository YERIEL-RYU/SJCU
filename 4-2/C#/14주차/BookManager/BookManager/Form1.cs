namespace BookManager
{
    public partial class Form1 : Form
    {
        List<Book> booklist = new List<Book>();
        BindingSource? bindingSource = new BindingSource();

        public Form1()
        {
            InitializeComponent();
            bindingSource.DataSource = booklist;
            dataGridView1.DataSource = bindingSource;
            dataGridView1.Columns[0].HeaderText = "저자";
            dataGridView1.Columns[1].HeaderText = "제목";
            dataGridView1.Columns[2].HeaderText = "연도";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.form1_bindingSource = bindingSource;
            form2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.form1_bindingSource = bindingSource;
            form3.ShowDialog();
        }
    }
}