using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace IntNode_and_stuff
{
    internal class IntNodeFunc : IntNode
    {
        public IntNodeFunc(int value, IntNode next) : base(value, next) { }

        // פעולה שמקבלת רשימה ומחזירה את מספר האברים בה 
        public int Count(IntNode n)
        {
            int count = 0;
            while (n != null)
            {
                count++;
                n = n.Next;
            }
            return count;
        }
        // פעולה שמקבלת רשימה ומחזירה את סכום האיברים ברשימה

        public int SumCount(IntNode n)
        {
            int sum = 0;
            while (n != null)
            {
                sum += n.Value;
                n = n.Next;
            }
            return sum;
        }
        // פעולה שמחזירה את ממוצע איברי המחלקה
        public int Average(IntNode n)
        {
            return this.SumCount(n) / this.Count(n);
        }
        // פעולה שמחזירה איבר מקסימלי במערך
        public IntNode GetMax(IntNode n)
        {
            IntNode max = new IntNode(int.MinValue, null);
            while (n != null)
            {
                if (max.Value < n.Value)
                    max.Value = Value;
                n = n.Next;
            }
            return max;
        }
        // פעולה שמחזירה את הערך של המספר המינימלי במערך 
        public int GetMinValue(IntNode n)
        {
            int min = int.MaxValue;
            while (n != null)
            {
                if (min > n.Value)
                    min = n.Value;
                n = n.Next;
            }
            return min;
        }
        // פעולה שמקבלת אינדקס ומחזירה ערך במקום שלו במידה ואין מחזיר -1 
        public int ValueByIndex(IntNode n, int indx)
        {
            int count = 0;
            while (n != null)
            {
                if (count == indx)
                    return n.Value;
                n = n.Next;
                count++;
            }
            return -1;
        }
        // פעולה שמדפיסה את כל הערכים הזוגיים של המערך
        public void PrintEvenValues(IntNode n)
        {
            int count = 0;
            while (n != null)
            {
                if (count % 2 == 0)
                    Console.Write(n.Value + " ");
                n = n.Next;
                count++; 
            }
        }

        }



    }
}
