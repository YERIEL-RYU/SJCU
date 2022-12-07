namespace EX30
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string? name = textBox1.Text;
            string? tel = textBox2.Text;

            dataGridView1.Rows.Add(name, tel);

            textBox1.Clear();
            textBox2.Clear();
        }
    }
}