using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rostelecom
{
    public partial class Entrance : Form
    {
        public Entrance()
        {
            InitializeComponent();
            button1.BringToFront();
            label1.BringToFront();
            label2.BringToFront();
            textBox1.BringToFront();
            textBox2.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "admin") && (textBox2.Text == "12345"))
            {
                MACADD MyFormMain = new MACADD();
                this.Hide();
                MyFormMain.ShowDialog();
                this.Show();
                Close();
            }
            else MessageBox.Show("Неверный логин или пароль");
        }
    }
}
