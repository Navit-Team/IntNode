using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntNode_and_stuff
{
    internal class IntNode
    {
        // משתני המחלקה
        public int Value { get; set; }
        public IntNode Next { get; set; }

        // בנאי
        public IntNode(int value) { Value = value; Next = null; }
        // בנאי עם אוברלווד
        public IntNode(int value, IntNode next) { this.Value = value; this.Next = next; }
        // פעולה שבודקת במידה ויש עוד משתנה למחלקה אחריי
        public bool HasNext() { return this.Next != null; }
        // פעולה שמחזירה את ערכי המחלקה
        public override string ToString()
        {
            return $"{this.Value}";
        }
    }

}
