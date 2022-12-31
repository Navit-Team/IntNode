namespace IntNode_and_stuff
{
    internal class IntNode
    {
        // משתני האובייקט
        public int Value { get; set; }

        public IntNode Next { get; set; }

        // בנאי
        public IntNode(int value, IntNode next = null) { this.Value = value; this.Next = next; }

        // פעולה שבודקת במידה ויש עוד משתנה למחלקה אחריי
        public bool HasNext() { return this.Next != null; }

        // פעולה שמחזירה את ערכי המחלקה
        public override string ToString() { return this.HasNext()  ?  this.Value + "->" + this.Next    :    this.Value + ""; }
    }
}