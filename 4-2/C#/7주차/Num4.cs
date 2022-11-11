namespace _19931538
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int result;
        string title = "결과";
        string msg;

        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(textBox1.Text);
            int num2 = int.Parse(textBox2.Text);
            result = num1 + num2;
            msg = num1 + " + " + num2 + " = " + result + " 입니다.";
            MessageBox.Show(msg, title);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(textBox1.Text);
            int num2 = int.Parse(textBox2.Text);
            result = num1 - num2;
            msg = num1 + " - " + num2 + " = " + result + " 입니다.";
            MessageBox.Show(msg, title);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(textBox1.Text);
            int num2 = int.Parse(textBox2.Text);
            result = num1 * num2;
            msg = num1 + " * " + num2 + " = " + result + " 입니다.";
            MessageBox.Show(msg, title);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(textBox1.Text);
            int num2 = int.Parse(textBox2.Text);
            result = num1 / num2;
            msg = num1 + " / " + num2 + " = " + result + " 입니다.";
            MessageBox.Show(msg, title);
        }
    }
}
