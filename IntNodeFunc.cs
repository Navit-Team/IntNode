using System;

namespace IntNode_and_stuff
{
    internal class IntNodeFunc : IntNode
    {
        public IntNodeFunc(int value, IntNode next = null) : base(value, next) { }

        // פעולה שמקבלת רשימה ומחזירה את מספר האברים בה 
        public int GetLength()
        {
            IntNode node = this;
            int count = 0;
            while (node != null)
            {
                count++;
                node = node.Next;
            }
            return count;
        }

        // פעולה שמקבלת רשימה ומחזירה את סכום האיברים ברשימה
        public int GetSum()
        {
            IntNode node = this;
            int sum = 0;
            while (node != null)
            {
                sum += node.Value;
                node = node.Next;
            }
            return sum;
        }

        // פעולה שמחזירה את ממוצע איברי הרשימה
        public int GetAverage()
        {
            IntNode node = this;
            int sum = 0;
            int count = 0;
            while (node != null)
            {
                sum += node.Value;
                count++;
                node = node.Next;
            }
            return sum / count;
        }

        // פעולה שמחזירה איבר מקסימלי במערך
        public int GetMax()
        {
            IntNode node = this;
            int max = int.MinValue;
            while (node != null)
            {
                if (node.Value > max)
                {
                    max = node.Value;
                }
                node = node.Next;
            }
            return max;
        }

        // פעולה שמחזירה את הערך של המספר המינימלי במערך 
        public int GetMin()
        {
            IntNode node = this;
            int min = int.MaxValue;
            while (node != null)
            {
                if (node.Value < min)
                {
                    min = node.Value;
                }
                node = node.Next;
            }
            return min;
        }

        // פעולה שמקבלת אינדקס ומחזירה ערך במקום שלו במידה ואין מחזיר נאל
        public int? GetFromIndex(int index)
        {
            if (index < 0)
                return null;

            IntNode node = this;
            int count = 0;
            while (node != null)
            {
                if (count == index)
                    return node.Value;
                count++;
                node = node.Next;
            }
            return null;
        }

        // פעולה שמדפיסה את כל הערכים הזוגיים של המערך
        public void PrintEvens()
        {
            IntNode node = this;
            string str = "";
            while (node != null)
            {
                if (node.Value % 2 == 0)
                    str += node.Value + ", ";
                node = node.Next;
            }
            Console.WriteLine(str.Remove(str.Length - 3));
        }

        // פעולה שמוחקת חולייה לפי מיקום ברשימה
        public void RemoveByIndex(int index)
        {
            if (index <= 0)
                return;

            IntNode node = this;
            int count = 0;
            while (node.Next != null)
            {
                if (index - 1 == count)
                {
                    node.Next = node.Next.Next;
                    return;
                }
                node = node.Next;
                count++;
            }
        }


        //          // תרגילים מהספר //


        // פעולה שבודקת מהוא מספר הרצפים ברשימה
        public int Ex2(int num)
        {
            IntNode node = this;
            int count = 0;
            bool equals, prvEquals = false;
            while (node != null)
            {
                equals = num == node.Value;
                if (equals && !prvEquals)
                    count++;
                prvEquals = equals;
                node = node.Next;
            }
            return count;
        }

        // פעולה שבודקת אם הרשימה מסודרת בסדר עולה
        public bool Ex3()
        {
            IntNode node = this;
            int prvNum;
            while (node.Next != null)
            {
                prvNum = node.Value;
                node = node.Next;
                if (prvNum > node.Value)
                    return false;
            }
            return true;
        }

        public char Ex4()
        {
            IntNode node = this;
            int[] count = { 0, 0 };// [0] -> Even  [1] -> Odd
            while (node.Next != null)
            {
                if (node.Value % 2 == 0)
                    count[0]++;
                else
                    count[1]++;
                node = node.Next;
            }
            return count[0] == count[1] ? 's' : (count[0] > count[1] ? 'z' : 'e');
        }
    }
}
