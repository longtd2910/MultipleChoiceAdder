using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multiple_Choice_Adder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void generate()
        {
            string[] a = { "A", "B", "C", "D" };
            int count = 0;
            string[] lines = textBox1.Text.Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToArray();
            for (int i = 0; i < lines.Length; ++i)
            {
                if (lines[i] == " ")
                {
                    lines[i] = "";
                }
            }
            for (int i = 0; i < lines.Length; ++i)
            {
                if (lines[i] != "")
                {
                    lines[i] = a[count++] + ". " + lines[i];
                }
            }
            textBox1.Text = string.Join(Environment.NewLine, lines);
            Clipboard.SetText(textBox1.Text);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            generate();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13) {
                generate();
            } 
        }
    }
}
