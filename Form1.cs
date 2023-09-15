using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Practic_10_09
{
    public partial class Form1 : Form
    {
        private ToolStripMenuItem status_bar = new ToolStripMenuItem("Строка состояния") { Checked = true, CheckOnClick = true };
        public Form1()
        {
            InitializeComponent();

            openFileDialog1.Filter = "Текстовые документы (*.txt)|*.txt|Все файлы (*.*)|*.*";
            saveFileDialog1.Filter = "Tекстовые документы (*.txt)|*.txt";

            ToolStripMenuItem file = new ToolStripMenuItem("Файл");

            ToolStripMenuItem create = new ToolStripMenuItem("Создать");
            create.ShortcutKeys = Keys.Control | Keys.N;
            create.Click += Create_Click;
            ToolStripMenuItem open = new ToolStripMenuItem("Открыть");
            open.ShortcutKeys = Keys.Control | Keys.O;
            open.Click += Open_Click;
            ToolStripMenuItem save = new ToolStripMenuItem("Сохранить");
            save.ShortcutKeys = Keys.Control | Keys.S;
            save.Click += Save_Click;


            file.DropDown.Items.Add(create);
            file.DropDown.Items.Add(open);
            file.DropDown.Items.Add(save);

            ToolStripMenuItem editing = new ToolStripMenuItem("Правка");

            ToolStripMenuItem cancel = new ToolStripMenuItem("Отменить");
            cancel.ShortcutKeys = Keys.Control | Keys.Z;
            cancel.Click += Cancel_Click;
            ToolStripMenuItem cut = new ToolStripMenuItem("Вырезать");
            cut.ShortcutKeys = Keys.Control | Keys.X;
            cut.Click += Cut_Click;
            ToolStripMenuItem copy = new ToolStripMenuItem("Копировать");
            copy.ShortcutKeys = Keys.Control | Keys.C;
            copy.Click += Copy_Click;
            ToolStripMenuItem insert = new ToolStripMenuItem("Вставить");
            insert.ShortcutKeys = Keys.Control | Keys.V;
            insert.Click += Insert_Click;
            ToolStripMenuItem delete = new ToolStripMenuItem("Удалить");
            delete.ShortcutKeys = Keys.Delete;
            delete.Click += Delete_Click;
            ToolStripMenuItem find = new ToolStripMenuItem("Найти");
            find.ShortcutKeys = Keys.Control | Keys.F;
            find.Click += Find_Click;
            ToolStripMenuItem replace = new ToolStripMenuItem("Заменить");
            replace.Click += Replace_Click;
            replace.ShortcutKeys = Keys.Control | Keys.H;
            ToolStripMenuItem go = new ToolStripMenuItem("Перейти");
            go.Click += Go_Click;
            go.ShortcutKeys = Keys.Control | Keys.G;
            ToolStripMenuItem select_all = new ToolStripMenuItem("Выделить всё");
            select_all.Click += Select_all_Click;
            select_all.ShortcutKeys = Keys.Control | Keys.A;
            ToolStripMenuItem time_date = new ToolStripMenuItem("Время и дата");
            time_date.ShortcutKeys = Keys.F5;
            time_date.Click += Time_date_Click;

            editing.DropDown.Items.Add(cancel);
            editing.DropDown.Items.Add(cut);
            editing.DropDown.Items.Add(copy);
            editing.DropDown.Items.Add(insert);
            editing.DropDown.Items.Add(delete);
            editing.DropDown.Items.Add(find);
            editing.DropDown.Items.Add(replace);
            editing.DropDown.Items.Add(go);
            editing.DropDown.Items.Add(select_all);
            editing.DropDown.Items.Add(time_date);

            ToolStripMenuItem format = new ToolStripMenuItem("Формат");

            ToolStripMenuItem word_wrap = new ToolStripMenuItem("Перенос по словам") { Checked = true, CheckOnClick = true };
            word_wrap.Click += Word_wrap_Click;
            ToolStripMenuItem font = new ToolStripMenuItem("Шрифт");
            font.Click += Font_Click;

            format.DropDown.Items.Add(word_wrap);
            format.DropDown.Items.Add(font);

            ToolStripMenuItem view = new ToolStripMenuItem("Вид");

            ToolStripMenuItem scale = new ToolStripMenuItem("Масштаб");

            ToolStripMenuItem increase = new ToolStripMenuItem("Увеличить");
            increase.ShortcutKeys = Keys.Control | Keys.Oemplus;
            increase.Click += Increase_Click;
            ToolStripMenuItem decrease = new ToolStripMenuItem("Уменьшить");
            decrease.ShortcutKeys = Keys.Control | Keys.OemMinus;
            decrease.Click += Decrease_Click;
            ToolStripMenuItem def = new ToolStripMenuItem("По умолчанию");
            def.ShortcutKeys = Keys.Control | Keys.D0;
            def.Click += Def_Click;

            
            status_bar.Click += Status_bar_Click;

            view.DropDown.Items.Add(scale);

            scale.DropDown.Items.Add(increase);
            scale.DropDown.Items.Add(decrease);
            scale.DropDown.Items.Add(def);

            view.DropDown.Items.Add(status_bar);

            ToolStripMenuItem reference = new ToolStripMenuItem("Справка");

            ToolStripMenuItem watch_reference = new ToolStripMenuItem("Посмотреть справку");
            watch_reference.Click += Watch_reference_Click;

            ToolStripMenuItem about_program = new ToolStripMenuItem("О программе");
            about_program.Click += About_program_Click;

            ToolStripMenuItem feedback = new ToolStripMenuItem("Отправить отзыв");
            feedback.Click += Feedback_Click;

            reference.DropDown.Items.Add(watch_reference);
            reference.DropDown.Items.Add(feedback);
            reference.DropDown.Items.Add(about_program);




            menuStrip1.Items.Add(file);
            menuStrip1.Items.Add(editing);
            menuStrip1.Items.Add(format);
            menuStrip1.Items.Add(view);
            menuStrip1.Items.Add(reference);
        }

        private void Feedback_Click(object sender, EventArgs e)
        {
            string url = "https://t.me/vadim3389";

            try
            {
                System.Diagnostics.Process.Start(url);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при открытии ссылки: " + ex.Message);
            }
        }

        private void About_program_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
        }

        private void Watch_reference_Click(object sender, EventArgs e)
        {
            string url = "https://www.bing.com/search?q=справка+по+использованию+блокнота+в+windows%c2%a010&filters=guid:\"4466414-ru-dia\"%20lang:\"ru\"&form=T00032&ocid=HelpPane-BingIA";

            try
            {
                System.Diagnostics.Process.Start(url);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при открытии ссылки: " + ex.Message);
            }
        }

        private void Status_bar_Click(object sender, EventArgs e)
        {
            toolStrip1.Visible = status_bar.Checked;
        }

        private void Def_Click(object sender, EventArgs e)
        {
            richTextBox1.ZoomFactor = 1.0f;
            UpdateZoomPercentage();
        }

        private void Decrease_Click(object sender, EventArgs e)
        {
            const float maximal_value = 0.1f;
            const float zoom_increment = 0.1f;

            if (richTextBox1.ZoomFactor - zoom_increment >= maximal_value)
            {
                richTextBox1.ZoomFactor -= zoom_increment;
                UpdateZoomPercentage();
            }
            else
            {

            }
        }

        private void Increase_Click(object sender, EventArgs e)
        {
            const float maximal_value = 5.0f;  
            const float zoom_increment = 0.1f;  

            if (richTextBox1.ZoomFactor + zoom_increment <= maximal_value)
            {
                richTextBox1.ZoomFactor += zoom_increment;
                UpdateZoomPercentage();
            }
            else
            {
                
            }
        }

        private void Font_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            int selectionStart = richTextBox1.SelectionStart;
            int selectionLength = richTextBox1.SelectionLength;

            richTextBox1.SelectionFont = fontDialog1.Font;

            richTextBox1.SelectionStart = selectionStart;
            richTextBox1.SelectionLength = selectionLength;
        }

        private void Word_wrap_Click(object sender, EventArgs e)
        {
            richTextBox1.WordWrap = !richTextBox1.WordWrap;
        }

        private string previous_text;

        private void Time_date_Click(object sender, EventArgs e)
        {
            string date_time = DateTime.Now.ToString();

            int cursor_position = richTextBox1.SelectionStart;

            richTextBox1.Text = richTextBox1.Text.Insert(cursor_position, date_time);
            richTextBox1.SelectionStart = cursor_position + date_time.Length;
        }

        private void Select_all_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void Go_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4(richTextBox1);

            form4.Show();
        }

        private void Replace_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(richTextBox1);

            form3.Show();
        }

        private void Find_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(richTextBox1);

            form2.Show();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectedText.Length > 0)
            {
                richTextBox1.Text = richTextBox1.Text.Remove(richTextBox1.SelectionStart, richTextBox1.SelectionLength);
            }
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            string text = Clipboard.GetText();
            int cursor_position = richTextBox1.SelectionStart;

            richTextBox1.Text = richTextBox1.Text.Insert(cursor_position, text);

            richTextBox1.SelectionStart = cursor_position + text.Length;
            richTextBox1.SelectionLength = 0;
        }

        private void Copy_Click(object sender, EventArgs e)
        {
            string selected_text = richTextBox1.SelectedText;

            Clipboard.SetText(selected_text);
        }

        private void Cut_Click(object sender, EventArgs e)
        {
            string selected_text = richTextBox1.SelectedText;

            Clipboard.SetText(selected_text);

            richTextBox1.SelectedText = string.Empty;
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = previous_text;
        }

        private void Create_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            string filename = saveFileDialog1.FileName;

            System.IO.File.WriteAllText(filename, richTextBox1.Text);

            richTextBox1.Clear();
        }

        private void Open_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;


            string filename = openFileDialog1.FileName;

            string fileText = System.IO.File.ReadAllText(filename);

            richTextBox1.Text = fileText;
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            string filename = saveFileDialog1.FileName;

            System.IO.File.WriteAllText(filename, richTextBox1.Text);
        }



        

        

        private void Form1_Load(object sender, EventArgs e)
        {
         
            UpdateCursorPosition();
            UpdateZoomPercentage();
        }

        private void UpdateCursorPosition()
        {
            int cursorPosition = richTextBox1.SelectionStart;

            int lineNumber = richTextBox1.GetLineFromCharIndex(cursorPosition) + 1;

            int columnNumber = cursorPosition - richTextBox1.GetFirstCharIndexFromLine(lineNumber - 1) + 1;

            toolStripLabel1.Text = "Стр " + lineNumber.ToString() + ", стлб: " + columnNumber.ToString();
        }

        private void UpdateZoomPercentage()
        {
            int zoomPercentage = (int)(richTextBox1.ZoomFactor * 100);

            toolStripLabel2.Text = zoomPercentage + "%";
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            UpdateCursorPosition();
            UpdateZoomPercentage();
        }
    }
}
