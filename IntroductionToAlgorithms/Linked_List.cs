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

        public T Node_Value { get; set; }
        //定义前驱元素
        public LNode<T> Prev { get; set; }
        //定义后驱元素
        public LNode<T> Next { get; set; }

        public LNode(T node_value)
        {
            this.Node_Value = node_value;
            this.Prev = null;
            this.Next = null;
        }
    }
    //双端循环链表
    public class Linked_List<T>
    {
        public int Count { get; set; }

        public LNode<T> Head { get; set; }
        public LNode<T> Tail { get; set; }
        //当创建链表时，默认为空，头元素和尾元素设为空
        public Linked_List()
        {
            this.Count = 0;
            this.Head = null;
            this.Tail = null;
        }
       

        public void HeadInsert(LNode<T> data)
        {
            if (this.Count == 0)
            {
                this.Head = data;
                this.Tail = data;
                this.Count++;
            }
            else
            {
                data.Next = this.Head.Next;
                this.Head.Next.Prev = data;
                this.Head = data;
                this.Count++;
            }
        }
        public void TailInsert(LNode<T> data)
        {
            if (this.Count == 0)
            {
                this.Head = data;
                this.Tail = data;
                this.Count++;
            }
            else
            {
                data.Prev = this.Tail.Prev;
                this.Tail.Prev.Next = data;
                this.Tail = data;
                this.Count++;
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
                if (x.Node_Value.Equals(value))
                {
                    return x;
                }
                else
                {
                    return null;
                }

            }
        }
        public void Delete(T value)
        {
            LNode<T> temp = List_Search(this, value);
            Delete(temp);
        }
        public void Delete(LNode<T> data)
        {
            if (data != null)
            {
                data.Next.Prev = data.Prev;
                data.Prev.Next = data.Next;
            }
            else
            {
                Console.WriteLine("The element is no exist!");
            }

        }
        public void PrintList()
        {
            LNode<T> temp = this.Head;
            while (temp != null )
            {
                Console.WriteLine(temp.Node_Value);
                temp = temp.Next;
            }
        }

    }
}
