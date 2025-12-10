using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS
{
    public class CodeDecode
    {
        public static string stringDecode(string a)
        {
            int l = a.Length, p;
            char[] k = new char[l];
            string s = "";
            for (int i = 0; i < l; i++)
            {
                p = (Convert.ToInt32(a[i]) - 1071) / 3;
                k[i] = Convert.ToChar(p);
                s = s + k[i].ToString();

            }
            return s;
        }
        public static string stringDecode_Organ(string a)
        {
            try
            {
                int l = a.Length, p;
                char[] k = new char[l];
                string s = "";
                for (int i = 0; i < l; i++)
                {
                    p = (Convert.ToInt32(a[i]) - 1071) / 3;
                    k[i] = Convert.ToChar(p);
                    s = s + k[i].ToString();

                }
                return s;
            }
            catch (Exception x)
            {
                return a;
            }

        }
        public static string stringcode(string a)
        {
            int l = a.Length, p;
            char[] k = new char[l];
            string s = "";
            for (int i = 0; i < l; i++)
            {
                p = 3 * Convert.ToInt32(a[i]) + 1071;
                k[i] = Convert.ToChar(p);
                s = s + k[i].ToString();
            }

            return s;
        }
    }
}