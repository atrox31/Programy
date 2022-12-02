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
    public partial class newName : Form
    {
        public newName()
        {
            newname = false;
            InitializeComponent();
        }
        bool newname;
        string name;
        
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                newname = true;
                name = textBox1.Text;
                this.Close();
            }
        }
        public string getNewName()
        {
            return newname?name:"";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            newname = true;
            name = textBox1.Text;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            newname = false;
            this.Close();
        }
        
    }
}
