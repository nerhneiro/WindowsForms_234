using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDouble(textBox1.Text) < 0) throw new Exception();
                label2.Text =  "Указанное число миль = " + (Convert.ToDouble(textBox1.Text)*1.6).ToString() + " км";
            }
            catch
            {
                label2.Text = "Неправильный формат ввода. Перевести мили в километры не удалось :( Проверьте, что ввели данные без пробелов и что они >= 0";
            }
        }
    }
}
