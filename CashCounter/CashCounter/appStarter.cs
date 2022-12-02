using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashCounter
{
    public partial class appStarter : Form
    {
        public appStarter()
        {
            InitializeComponent();
            textBox1.Focus();
        }

        private void appStarter_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
            #if DEBUG
            Start(true);
            this.Hide();
            #endif

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Start();
        }

        private void Start(bool debug = false)
        {
            //if (!int.TryParse(textBox1.Text, out int parsedValue) && !debug)
            //    MessageBox.Show("Numer stacji musi składać się z cyfr!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //else
            {
                Form1 a = new Form1(textBox1.Text);
                a.Show();
                this.Hide();
            }
            //textBox1.Focus();
            //textBox1.SelectAll();

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                Start();
            }
        }
    }
}
