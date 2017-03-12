using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToAlgorithms
{

    //数据类，暂时用于链表的构建
    public class LNode<T>
    {
        private T node_value;
        public T Node_Value
        {
            get { return node_value; }
            set { node_value = value; }
        }
        private LNode<T> prev;//定义前驱元素
        public LNode<T> Prev
        {
            get { return prev; }
            set { prev = value; }
        }
        private LNode<T> next;//定义后驱元素
        public LNode<T> Next
        {
            get { return next; }
            set { next = value; }
        }
        public LNode(T node_value)
        {
            this.Node_Value = node_value;
            this.Prev = null;
            this.Next = null;
        }
    }
    public class Linked_List<T>
    {
        //定义链表长度
        private int count;
        public int Count
        {
            get { return count; }
            set { count = value; }
        }
        LNode<T> head;//定义头元素
        public LNode<T> Head
        {
            get { return head; }
        }
        LNode<T> tail;//定义尾元素
        public LNode<T> Tail
        {
            get { return tail; }
        }
        //当创建链表时，默认为空，头元素和尾元素设为空
        public Linked_List()
        {
            Count = 0;
            head = tail = null;
        }
        //当开始插入元素时，检查链表长度，为0则将头元素和尾元素设为传入的参数。
        //当长度不为0，则将尾元素与传入的元素进行连接。
        //自己实现的插入，插入方式是在元素尾部插入
        //public void Insert(Node<T> data)
        //{
        //    if (this.Count == 0)
        //    {
        //        head = tail = data;
        //        Count++;
        //    }
        //    else
        //    {
        //        Node<T> temp = tail;
        //        tail.Next = data;
        //        data.Prev = tail;
        //        tail = data;
        //        Count++;
        //    }
        //}

        public void Insert(LNode<T> data)
        {
            if (this.Count == 0)
            {
                this.head = this.tail = data;
                Count++;
            }
            else
            {
                data.Next = this.head;
                this.head.Prev = data;
                this.head = data;
                Count++;
            }
        }
        public static LNode<T> List_Search(Linked_List<T> list, T value)
        {
            if (list.Count == 0)
            {
                Console.WriteLine("The Linked List Is Empty!!");
                return null;
            }
            else
            {
                LNode<T> x = list.Head;
                while (x != null && !x.Node_Value.Equals(value))
                {
                    x = x.Next;
                }
                return x;
            }
        }
        public void PrintList()
        {
            LNode<T> temp = this.Head;
            for (int i = 0; i < Count; i++)
            {
                Console.WriteLine(temp.Node_Value);
                temp = temp.Next;
            }
        }

    }
}
