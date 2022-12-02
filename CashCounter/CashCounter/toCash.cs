using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashCounter
{
    class toCash
    {
        public static string con( double input)
        {
            string cash = input.ToString();
            string fCash = cash.Split(',')[0];
            string sCash;
            if (cash.Contains(','))
            {
                sCash = cash.Split(',')[1];
                if (sCash.Length == 1)
                {
                    sCash = sCash + "0";
                }
            }
            else
            {
                sCash = "00";
            }
            if (fCash.Length > 3)
            {
                string temp = "";
                int j = 1;
                for (int i = fCash.Length - 1; i >= 0; i--)
                {
                    temp += fCash[i];
                    if (j++ % 3 == 0)
                        temp += " ";
                }
                fCash = ReverseString(temp);
            }
            return fCash + "." + sCash + " ,-";
        }
        public static string ReverseString(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
    }
}
