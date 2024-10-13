using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSLKDon
{
    internal class MyList
    {
        private IntNode first;
        private IntNode last;

        internal IntNode First { get => first; set => first = value; }
        internal IntNode Last { get => last; set => last = value; }
        public MyList()
        {
            first = null;
            last = null;
        }
        public bool IsEmty()
        {
            return first == null;

        }
        public void AddFirst(IntNode newNode)
        {
            if (IsEmty())
                first = last = newNode;
            else
            {
                newNode.Next = first;
                first = newNode;
            }
        }
        //AddLast
        public void AddLast(IntNode newNode)
        {
            if (IsEmty())
                first = last = newNode;
            else
            {
                last.Next = newNode;
                last = newNode;
            }
        }
        public IntNode GetMax()
        {
            if (IsEmty()) return null;
            IntNode maxNode = first;
            for (IntNode p = first; p != null; p = p.Next)
            {
                if (p.Data > maxNode.Data)
                    maxNode = p;
            }
            return maxNode;
        }
        public IntNode GetMin()
        {
            if (IsEmty()) return null;
            IntNode minNode = first;
            for (IntNode p = first; p != null; p = p.Next)
            {
                if (p.Data < minNode.Data)
                    minNode = p;
            }
            return minNode;
        }
        public MyList GetEvenList()
        {
            MyList evenList = new MyList();
            IntNode p = first;
            while (p != null)
            {
                if (p.Data % 2 == 0)
                {
                    evenList.AddLast(new IntNode(p.Data));
                }
                p = p.Next;
            }
            return evenList;
        }
        public MyList GetOddList()
        {
            MyList oddList = new MyList();
            IntNode p = first;
            while (p != null)
            {
                if (p.Data % 2 != 0)
                {
                    oddList.AddLast(new IntNode(p.Data));
                }
                p = p.Next;
            }
            return oddList;
        }
        public MyList JoinList1(MyList myList2)
        {
            MyList myList3=new MyList();
            IntNode p = first;
            while (p != null)
            {
                IntNode newNode=new IntNode(p.Data);
                myList3.AddLast(newNode);
                p= p.Next;
            }
            p = myList2.first;
            while(p != null)
            {
                IntNode newNode=new IntNode(p.Data);
                myList3.AddLast(newNode);
                p = p.Next;
            }
            return myList3;
        }
        public MyList JoinList2(MyList myList2)
        {
            MyList myList3 = new MyList();
            IntNode p1=first;
            IntNode p2 = myList2.first;
            while(p1!= null && p2!=null)
            {
                IntNode newNode=new IntNode(p1.Data);
                myList3.AddLast(newNode);
                p1 = p1.Next;
                newNode=new IntNode(p2.Data);
                myList3.AddLast(newNode);
                p2 = p2.Next;
            }
            while(p1!= null)
            {
                IntNode newNode = new IntNode(p1.Data);
                myList3.AddLast(newNode);
                p1= p1.Next;
            }
            while(p2!= null)
            {
                IntNode newNode= new IntNode(p2.Data);  
                myList3.AddLast(newNode);
                p2= p2.Next;
            }
            return myList3;
        }


       
        public void Input1()
        {
            int x;
            do
            {
                Console.Write("Mời nhập giá trị (Nhập giá trị 0 để kết thúc): ");
                int.TryParse(Console.ReadLine(), out x);
                if (x == 0)
                    return;
                IntNode newNode = new IntNode(x);
                AddFirst(newNode);
            } while (true);

        }
        public void Input2()
        {
            int x;
            do
            {
                Console.Write("Mời nhập giá trị (Nhập giá trị 0 để kết thúc): ");
                int.TryParse(Console.ReadLine(), out x);
                if (x == 0)
                    return;
                IntNode newNode = new IntNode(x);
                AddLast(newNode);
            } while (true);

        }
        public void ShowList()
        {
            IntNode p = first;
            while (p != null)
            {
                Console.Write($"{p.Data} -> ");
                p = p.Next;
            }
            Console.WriteLine("null");
        }
        public IntNode SearchX(int x)
        {
            IntNode p = first;
            while (p != null)
            {
                if (p.Data == x)
                    return p;
                p = p.Next;
            }
            return null;
        }

    }
}

