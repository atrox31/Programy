using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashCounter
{
    class arkusz
    {
        private bool closed;
        //public uint v500, v200, v100, v50, v20, v10, v5, v2, v1, v050, v020, v010, v005, v002, v001;
        public IDictionary<string, uint> values = new Dictionary<string, uint>();
        public arkusz()
        {
            closed = false;
            values["v500"] = 0;
            values["v200"] = 0;
            values["v100"] = 0;
            values["v50"] = 0;
            values["v20"] = 0;
            values["v10"] = 0;
            values["v5"] = 0;
            values["v2"] = 0;
            values["v1"] = 0;
            values["v050"] = 0;
            values["v020"] = 0;
            values["v010"] = 0;
            values["v005"] = 0;
            values["v002"] = 0;
            values["v001"] = 0;
        }

        public bool ifClosed()
        {
            return closed;
        }

        public void close()
        {
            closed = true;
        }
        
        public bool setValue( string var, int new_val)
        {
            if (closed) return false;
            int val = (int)values["v"+var] + new_val;
            if (val < 0)
            {
                System.Windows.Forms.MessageBox.Show("Końcowa wartość jest ujemna!", "Błąd", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                return false;
            }
            else
            {
                values["v" + var] = Convert.ToUInt32(val);
            }
            return true;
        }
        public double getCash( string var)
        {
            double value = Convert.ToDouble(var);
            if (var.ElementAt(0) == '0' && var.ElementAt(1) == '0')
                value /= 100;
            if (var.ElementAt(0) == '0' && var.ElementAt(1) != '0')
                value /= 100;
            return value;
        }

        public uint[] getAllValues()
        {
            return new uint[15]
            {
                values["v500"],values["v200"],values["v100"],values["v50"],values["v20"],values["v10"],values["v5"],values["v2"],values["v1"],values["v050"],values["v020"],values["v010"],values["v005"],values["v002"],values["v001"]
            };
        }

        public static double[] getAllNomins()
        {
            return new double[15]
            {
                500,200,100,50,20,10,5,2,1,0.5,0.2,0.1,0.05,0.02,0.01
            };
        }

        public uint getValue(string var)
        {
            return values["v" + var];
        }
        public void setAllTo0(string name)
        {
            if(System.Windows.Forms.MessageBox.Show("Wyzerować arkusz '"+name+"'?", "Wyczyść arkusz", System.Windows.Forms.MessageBoxButtons.YesNo, System.Windows.Forms.MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                foreach (var key in values.Keys.ToList())
                {
                    values[key] = 0;
                }
            }
        }
    }
}
