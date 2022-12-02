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
    public partial class appTable : Form
    {
        public appTable( string[][] values )
        {
            InitializeComponent();
            for (int i = 0; i < values.Length; i++)
            {
                dataGridView1.Rows.Add(values[i][0], values[i][1]);
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void appTable_Load(object sender, EventArgs e)
        {

        }
    }
}
