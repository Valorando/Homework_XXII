using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practic_10_09
{
    public partial class Form2 : Form
    {
        private readonly TextBox _textBoxInForm1;

        public Form2(TextBox textBoxInForm1)
        {
            InitializeComponent();
            _textBoxInForm1 = textBoxInForm1;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text_for_search = textBox1.Text;
            string text_to_search = _textBoxInForm1.Text; 

            int startIndex = 0;

            if (radioButton2.Checked)
            {
                
                startIndex = text_to_search.Length - 1;
            }

            int index = text_to_search.IndexOf(text_for_search, startIndex);

            if (checkBox1.Checked)
            {
                
                index = text_to_search.IndexOf(text_for_search, startIndex, StringComparison.Ordinal);
            }
            else
            {
                
                index = text_to_search.IndexOf(text_for_search, startIndex, StringComparison.OrdinalIgnoreCase);
            }

            if (index != -1)
            {
                
                _textBoxInForm1.Focus();
                _textBoxInForm1.Select(index, text_for_search.Length);
                _textBoxInForm1.ScrollToCaret();
            }
            else
            {
                MessageBox.Show($"Не удается найти {text_for_search} ", "Блокнот", MessageBoxButtons.OK, MessageBoxIcon.Information); 
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
