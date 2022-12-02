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
    public partial class Form1 : Form
    {
        const uint MAX_ARKUSZ = 12;
        uint arkusz_nr = 0;

        arkusz[] lista_arkuszy = new arkusz[MAX_ARKUSZ];
        public Form1(string text)
        {
            NrStacji = text;
            InitializeComponent();
            this.Text = "Raport gotówki dla: " + this.NrStacji;
            for (int i = 0; i < MAX_ARKUSZ; i++)
            {
                lista_arkuszy[i] = null;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count < MAX_ARKUSZ)
            {
                lista_arkuszy[listBox1.Items.Count] = new arkusz();
                listBox1.Items.Add("Arkusz " + (arkusz_nr++).ToString());
                listBox1.SelectedIndex = listBox1.Items.Count-1;
                buttonDelete.Enabled = true;
                buttonClose.Enabled = true;
                buttonSetTo0.Enabled = true;
                if (listBox1.Items.Count == MAX_ARKUSZ)
                {
                    buttonAdd.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Osiągnięto maksymalną liczbę arkuszy!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            // czy można
            if (listBox1.Items.Count == 0)
                return;
            if (listBox1.SelectedIndex == -1)
                return;
            // =================================
            if (System.Windows.Forms.MessageBox.Show("Usunąć arkusz '" + listBox1.SelectedItem.ToString() + "'?", "Usuń arkusz", System.Windows.Forms.MessageBoxButtons.YesNo, System.Windows.Forms.MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                if (listBox1.SelectedIndex == listBox1.Items.Count - 1)
                {// ostatni
                    lista_arkuszy[listBox1.SelectedIndex] = null;
                }
                else
                {
                    for (int i = listBox1.SelectedIndex; i < listBox1.Items.Count - 1; i++)
                    {
                        lista_arkuszy[i] = lista_arkuszy[i + 1];
                    }
                    lista_arkuszy[listBox1.Items.Count - 1] = null;
                }
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                if (listBox1.Items.Count == 0)
                {
                    buttonDelete.Enabled = false;
                    buttonClose.Enabled = false;
                    buttonSetTo0.Enabled = false;

                    var tInput = this.Controls.Cast<Control>()
                         .Where(c => c.Name.StartsWith("inputTo"));
                    for (int i = 0; i < 15; i++)
                    {
                        ((TextBox)tInput.ElementAt(i)).Enabled = false;
                    }
                }
                else
                {
                    listBox1.SelectedIndex = 0;
                }
                // odblowowanie nowych arkuszy
                if (listBox1.Items.Count < MAX_ARKUSZ)
                    buttonAdd.Enabled = true;
                refreshInfo();
            }
        }

        private void inputTo500_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bool gonext = true;
                if (((TextBox)sender).Text != "")
                {
                    if (!int.TryParse(((TextBox)sender).Text, out int parsedValue))
                    {
                        MessageBox.Show("Podana wartość ('" + ((TextBox)sender).Text + "') nie jest liczbą!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        gonext = false;
                    }
                    else
                    {
                        string varName = ((TextBox)sender).Name.Remove(0, 7);
                        if (lista_arkuszy[listBox1.SelectedIndex].setValue(varName, Convert.ToInt16(((TextBox)sender).Text)))
                        {
                            ((TextBox)this.Controls.Find("valueTo" + varName, true)[0]).Text = Convert.ToString(lista_arkuszy[listBox1.SelectedIndex].getValue(varName));
                            ((Label)this.Controls.Find("labelSum" + varName, true)[0]).Text = "= " + toCash.con(Convert.ToDouble(lista_arkuszy[listBox1.SelectedIndex].getValue(varName)) * lista_arkuszy[listBox1.SelectedIndex].getCash(varName)).ToString();
                        }
                        else
                        {
                            gonext = false;
                        }
                    }
                }
                if (gonext)
                {
                    ((TextBox)sender).Text = "";
                    this.SelectNextControl( (Control)sender, radioButton2.Checked, true, true, true);
                    // 11 - 39
                    if(radioButton2.Focused || radioButton1.Focused)
                    {
                        buttonClose.Focus();
                    }
                }
                else
                {
                    ((TextBox)sender).SelectAll();
                }
                refreshInfo();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1) return;
            var tboxes = this.Controls.Cast<Control>()
                     .Where(c => c.Name.StartsWith("valueTo"));
            var tLabels = this.Controls.Cast<Control>()
                     .Where(c => c.Name.StartsWith("labelSum"));
            var tInput = this.Controls.Cast<Control>()
                     .Where(c => c.Name.StartsWith("inputTo"));
            for (int i = 0; i < 15; i++)
            {
                string eName = tboxes.ElementAt(i).Name.Remove(0, 7);
                ((TextBox)tboxes.ElementAt(i)).Text = 
                    Convert.ToString(
                        lista_arkuszy[listBox1.SelectedIndex].getValue(eName));

                ((TextBox)tInput.ElementAt(i)).Enabled = true;

                ((Label)this.Controls.Find("labelSum" + eName, true)[0]).Text = "= " + 
                    toCash.con(Convert.ToDouble(
                        lista_arkuszy[listBox1.SelectedIndex].getValue(eName) * lista_arkuszy[listBox1.SelectedIndex].getCash(eName)

                        ));
           
            }
            refreshInfo();


        }

        private void refreshInfo()
        {
            if (listBox1.Items.Count == 0) return;
            var tboxes = this.Controls.Cast<Control>()
                     .Where(c => c.Name.StartsWith("valueTo"));
            // sumuj arkusze
            double suma_arkusza = 0;
            double suma_całości = 0;
            double[] nomins = arkusz.getAllNomins();
            for (int i = 0; i < MAX_ARKUSZ; i++)
            {
                // jeżeli jest arkusz
                if(lista_arkuszy[i] != null)
                {
                    double aSum = 0;
                    uint[] cArkusz = lista_arkuszy[i].getAllValues();
                    for (int j = 0; j < nomins.Length; j++)
                    {
                        aSum += cArkusz[j] * nomins[j];
                    }

                    // czy aktualny
                    if(i == listBox1.SelectedIndex)
                    {
                        suma_arkusza = aSum;
                    }
                    suma_całości += aSum;
                }
            }
            labelSumaWszystko.Text = toCash.con(suma_całości);
            labelSumaArkusz.Text = toCash.con(suma_arkusza);
            // jeszcze odśwież prawe boxy
            for (int i = 0; i < 15; i++)
            {
                string eName = tboxes.ElementAt(i).Name.Remove(0, 7);
                ((TextBox)tboxes.ElementAt(i)).Text =
                    Convert.ToString(
                        lista_arkuszy[listBox1.SelectedIndex].getValue(eName));
                ((Label)this.Controls.Find("labelSum" + eName, true)[0]).Text = "= " +
                    toCash.con(Convert.ToDouble(
                        lista_arkuszy[listBox1.SelectedIndex].getValue(eName) * lista_arkuszy[listBox1.SelectedIndex].getCash(eName)

                        ));
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void buttonFinish_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count == 0) return;
            double[] nomins = arkusz.getAllNomins();
            string[] tempS = new string[nomins.Length];
            int[]    tempI = new int[nomins.Length];
            //string[][] temp = new string[nomins.Length][0];       wartości
            //string[][] temp = new string[nomins.Length][1];       nominały
            for (int i = 0; i < nomins.Length; i++)
            {
                tempS[i] = toCash.con(nomins[i]);
                tempI[i] = 0;
            }
            for (int i = 0; i < MAX_ARKUSZ; i++)
            {
                // jeżeli jest arkusz
                if (lista_arkuszy[i] != null)
                    {
                    uint[] values = lista_arkuszy[i].getAllValues();
                    for (int j = 0; j < values.Length; j++)
                    {
                        tempI[j] += (int)values[j];
                    }
                }
            }
            string[][] ret = new string[nomins.Length][];
            for (int i = 0; i < nomins.Length; i++)
                {
                    ret[i] = new string[2];
                    ret[i][0] = tempI[i].ToString();
                    ret[i][1] = tempS[i];
                }
            appTable ap = new appTable( ret );
            ap.ShowDialog();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1) return;
            if (listBox1.Items.Count == 0) return;
            if (!lista_arkuszy[listBox1.SelectedIndex].ifClosed())
            {
                lista_arkuszy[listBox1.SelectedIndex].close();
                listBox1.Items[listBox1.SelectedIndex] = "[z] " + listBox1.Items[listBox1.SelectedIndex];
            }
        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = listBox1.IndexFromPoint(e.Location);
            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                newName nn = new newName();
                nn.ShowDialog();
                string name = nn.getNewName();
                if (name != "") {
                    if (lista_arkuszy[listBox1.SelectedIndex].ifClosed())
                    {
                        listBox1.Items[listBox1.SelectedIndex] = "[z] ";
                    }
                    else
                    {
                        listBox1.Items[listBox1.SelectedIndex] = "";
                    }
                    listBox1.Items[listBox1.SelectedIndex] += name;
                }
            }

        }

        private void buttonSetTo0_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1) return;
            if (listBox1.Items.Count == 0) return;
            lista_arkuszy[listBox1.SelectedIndex].setAllTo0(listBox1.SelectedItem.ToString());
            refreshInfo();
        }
    }
}
