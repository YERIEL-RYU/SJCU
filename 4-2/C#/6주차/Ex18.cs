namespace Ex18.cs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int elapsedTime = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            elapsedTime++;
            textBox1.Text = elapsedTime + "초 경과";
            label1.Text = elapsedTime + "초 경과";
        }
    }
}