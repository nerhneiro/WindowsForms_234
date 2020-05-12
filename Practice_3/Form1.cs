using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Text = "Press Me";
            button1.Text = "Press meeee";
            button1.Location = new Point(100, 156);
            button1.Name = "button1";
            button1.Size = new Size(200, 23);
        }
        int Clicker = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            Clicker++;
            if (Clicker == 1) button1.Text = "you pressed me";
            else Close();
        }
    }
}
