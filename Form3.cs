using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practic_10_09
{
    public partial class Form3 : Form
    {
        private readonly RichTextBox _textBoxInForm1;
        public Form3(RichTextBox textBoxInForm1)
        {
            InitializeComponent();
            _textBoxInForm1 = textBoxInForm1;
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text_for_search = textBox1.Text;
            string text_for_replace = textBox2.Text;

            string textToSearchAndReplace = _textBoxInForm1.Text;

            StringComparison comparisonType = checkBox1.Checked ? StringComparison.Ordinal : StringComparison.OrdinalIgnoreCase;


            if (textToSearchAndReplace.IndexOf(text_for_search, comparisonType) >= 0)
            {
                textToSearchAndReplace = textToSearchAndReplace.Replace(text_for_search, text_for_replace);

                _textBoxInForm1.Text = textToSearchAndReplace;
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
