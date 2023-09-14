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
    public partial class Form4 : Form
    {
        private readonly TextBox _textBoxInForm1;
        public Form4(TextBox textBoxInForm1)
        {
            InitializeComponent();
            _textBoxInForm1 = textBoxInForm1;
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int string_number))
            {
                
                if (string_number >= 1 && string_number < _textBoxInForm1.Lines.Length)
                {
                    int index = string_number - 1;
                    _textBoxInForm1.Focus();
                    _textBoxInForm1.SelectionStart = _textBoxInForm1.GetFirstCharIndexFromLine(string_number);
                    _textBoxInForm1.SelectionLength = 0; 
                    _textBoxInForm1.ScrollToCaret(); 
                }
              
                else
                {
                    MessageBox.Show("Строка не найдена.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Введен некорректный номер строки.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
       
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
