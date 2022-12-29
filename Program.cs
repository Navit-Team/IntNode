using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace IntNode_and_stuff
{
    internal class Program
    {
        // פעולה שבודקת גדול רצף של ספרה
        public static int GetStrike(IntNode n, int num)
        {
            int count = 0;
            while (n != null)
            {
                if (n.Value == num)
                {
                    n = n.Next;
                    if (n.Value == num)
                        count++;
                    n = n.Next;
                }
            }
            return count;
        }
        // פעולה שבודקת במקרה והמערך מסודר בסדר עולה
        public static bool ISRising(IntNode n)
        {
            while (n != null)
            {
                int last = n.Value;
                n = n.Next;
                if (n.Value < last)
                    return false; 
            }
            return true;
        }
        // פעולה שבודקת במקרה ויש יותר או פחות או שווה ערכים שליליים או חיוביים
        public static char NegPosEquel(IntNode n)
        {
            int pos = 0, neg = 0;
            while (n != null)
            {
                if (n.Value > 0)
                    pos++;
                else
                    neg++;
                n = n.Next; 
            }
            if (pos > neg)
                return 'z';
            else if (pos == neg)
                return 's';
            return 'e'; 
        }

        static void Main(string[] args)
        {
            IntNodeFunc a = new IntNodeFunc(1);
            IntNodeFunc b = new IntNodeFunc(3, a);
            IntNodeFunc n = new IntNodeFunc(5, b);

            n.DeleteValue(n, 0);
            Console.WriteLine(n.ToString());
        }
    }
}
