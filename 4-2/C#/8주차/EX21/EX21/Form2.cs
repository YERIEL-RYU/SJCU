using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public void setNameAndScore(string name, int score)
        {
            label1.Text = name + "님의 성적 합계는" + score + "입니다.";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
