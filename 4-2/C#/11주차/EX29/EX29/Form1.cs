namespace EX29
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string? combobox = comboBox1.SelectedItem as string;
            string? listbox = listBox1.SelectedItem as string;

            MessageBox.Show(combobox + ", " + listbox + "를 선택하였습니다.");
        }
    }
}