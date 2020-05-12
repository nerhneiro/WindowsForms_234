using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice_4
{
    public partial class Form1 : Form
    {
        public Form1() 
        { 
            InitializeComponent();
            label2.Location = new Point(i, 277);
            button2.Visible = false;
        }
        static public Random r = new Random();
        int i = 140;
        int n = 0;
        float wrong = 10;
        private void button1_Click(object sender, EventArgs e)
        {
            n++;
            if (n < 11)
            {
               
                int rand = r.Next(0, 11);
                try
                {
                    if (int.Parse(textBox1.Text) > 10 || int.Parse(textBox1.Text) < 0) throw new Exception("error"); if (int.Parse(textBox1.Text) == rand) { label2.Text = "Вы угадали!"; wrong = wrong - 1; }
                        else
                        {
                            label2.Text = "Вы не угадали :(  Это было число: " + rand;
                            i += 20; label2.Location = new Point(i, 277);
                            wrong = wrong;
                        }
                }
                catch (Exception err){ label2.Text = "Неправильный ввод :("; n--; }
            }
            else 
            { 
                label3.Text = "Выш общий коэффициент невезучести = " + wrong / 10;
                button2.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            n = 0;
            wrong = 10;
            i = 140;
            label2.Text = "";
            label3.Text = "";
            button2.Visible = false;
        }
    }
}
