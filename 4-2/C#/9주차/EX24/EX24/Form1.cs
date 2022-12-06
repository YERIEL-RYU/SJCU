using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX24
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void 열기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Visible = true;
            toolStripStatusLabel2.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Visible = true;
            toolStripStatusLabel1.Visible = false;
        }

        private void 이름ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("제 이름은 김세종입니다.");
        }

        private void 사는곳ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("제가 사는 곳은 서울시 광진구입니다.");
        }
    }
}
