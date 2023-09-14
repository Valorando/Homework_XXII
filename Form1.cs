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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            ToolStripMenuItem file = new ToolStripMenuItem("Файл");

            ToolStripMenuItem create = new ToolStripMenuItem("Создать");
            create.ShortcutKeys = Keys.Control | Keys.N;
            ToolStripMenuItem open = new ToolStripMenuItem("Открыть");
            open.ShortcutKeys = Keys.Control | Keys.O;
            ToolStripMenuItem save = new ToolStripMenuItem("Сохранить");
            save.ShortcutKeys = Keys.Control | Keys.S;
            

            file.DropDown.Items.Add(create);
            file.DropDown.Items.Add(open);
            file.DropDown.Items.Add(save);

            ToolStripMenuItem editing = new ToolStripMenuItem("Правка");

            ToolStripMenuItem cancel = new ToolStripMenuItem("Отменить");
            cancel.ShortcutKeys = Keys.Control | Keys.Z;
            ToolStripMenuItem cut = new ToolStripMenuItem("Вырезать");
            cut.ShortcutKeys = Keys.Control | Keys.X;
            ToolStripMenuItem copy = new ToolStripMenuItem("Копировать");
            copy.ShortcutKeys = Keys.Control | Keys.C;
            ToolStripMenuItem insert = new ToolStripMenuItem("Вставить");
            insert.ShortcutKeys = Keys.Control | Keys.V;
            ToolStripMenuItem delete = new ToolStripMenuItem("Удалить");
            delete.ShortcutKeys = Keys.Delete;
            ToolStripMenuItem find = new ToolStripMenuItem("Найти");
            find.ShortcutKeys = Keys.Control | Keys.F;

            ToolStripMenuItem replace = new ToolStripMenuItem("Заменить");
            replace.ShortcutKeys = Keys.Control | Keys.H;
            ToolStripMenuItem go = new ToolStripMenuItem("Перейти");
            go.ShortcutKeys = Keys.Control | Keys.G;
            ToolStripMenuItem select_all = new ToolStripMenuItem("Выделить всё");
            select_all.ShortcutKeys = Keys.Control | Keys.A;
            ToolStripMenuItem time_data = new ToolStripMenuItem("Время и дата");
            time_data.ShortcutKeys = Keys.F5;

            editing.DropDown.Items.Add(cancel);
            editing.DropDown.Items.Add(cut);
            editing.DropDown.Items.Add(copy);
            editing.DropDown.Items.Add(insert);
            editing.DropDown.Items.Add(delete);
            editing.DropDown.Items.Add(find);
            editing.DropDown.Items.Add(replace);
            editing.DropDown.Items.Add(go);
            editing.DropDown.Items.Add(select_all);
            editing.DropDown.Items.Add(time_data);

            ToolStripMenuItem format = new ToolStripMenuItem("Формат");

            ToolStripMenuItem word_wrap = new ToolStripMenuItem("Перенос по словам") { Checked = true, CheckOnClick = true };
            word_wrap.Click += Word_wrap_Click;
            ToolStripMenuItem font = new ToolStripMenuItem("Шрифт");
            font.Click += Font_Click;

            format.DropDown.Items.Add(word_wrap);
            format.DropDown.Items.Add(font);

            ToolStripMenuItem view = new ToolStripMenuItem("Вид");

            ToolStripMenuItem scale = new ToolStripMenuItem("Масштаб");
            ToolStripMenuItem status_bar = new ToolStripMenuItem("Строка состояния") { Checked = true, CheckOnClick = true };
            status_bar.Click += Status_bar_Click;

            view.DropDown.Items.Add(scale);
            view.DropDown.Items.Add(status_bar);

            ToolStripMenuItem reference = new ToolStripMenuItem("Справка");

            ToolStripMenuItem about_program = new ToolStripMenuItem("О программе");

            reference.DropDown.Items.Add(about_program);



            menuStrip1.Items.Add(file);
            menuStrip1.Items.Add(editing);
            menuStrip1.Items.Add(format);
            menuStrip1.Items.Add(view);
            menuStrip1.Items.Add(reference);
        }

        private void Status_bar_Click(object sender, EventArgs e)
        {
            
        }

        private void Word_wrap_Click(object sender, EventArgs e)
        {
            
        }

        private void Font_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
