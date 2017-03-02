using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToAlgorithms
{
    public class DataStructure
    {
        #region 数据结构
        /// <summary>
        /// 00:00:00.0004319 c#内置Stack,push后pop10000的时间
        ///00:00:00.0018118  我自己实现的Stack时间，有待优化
        ///00:00:00.0036212  利用c#内置的泛型集合实现的类似内置Stack，速度确实最慢的
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public class Stack<T> //（泛型数组Stack）
        {
            int top = -1;
            int length = 0;
            T[] Stack_Value;
            public Stack(int length)
            {
                Stack_Value = new T[length];
                this.length = Stack_Value.Length;
            }
            public bool Stack_Empty()
            {
                if (this.top != -1)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            public T Pop()
            {
                if (this.top == -1)
                {
                    Console.WriteLine("There is no element in the stack");
                    return default(T);
                }
                else
                {
                    this.top--;
                    return this.Stack_Value[top + 1];
                }
            }
            public void Push(T value)
            {
                this.top++;
                if (this.top == this.length)
                {
                    Console.WriteLine("Stack OverFlow");
                }
                else
                {
                    this.Stack_Value[this.top] = value;
                }
            }
        }
        public class Stackk<T>
        {

            List<T> Stackk_Value;
            public Stackk(int Count)
            {
                Stackk_Value = new List<T>(Count);

            }
            public bool Stack_Empty()
            {
                if (this.Stackk_Value.Count == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            public void Push(T value)
            {
                this.Stackk_Value.Add(value);
            }
            public T Pop()
            {
                T temp = this.Stackk_Value[this.Stackk_Value.Count - 1];
                this.Stackk_Value.RemoveAt(this.Stackk_Value.Count - 1);
                return temp;
            }
        }//（泛型集合Stack）
        public class Queue<T>
        {
            int length = 0;
            int head = 0;
            int tail = 0;
            T[] Queue_Value;
            public Queue(int length)
            {
                Queue_Value = new T[length];
            }
            public bool Queue_Empty()
            {
                if (Queue_Value.Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            public void Enqueue(T value)
            {
                if (true)
                {

                }
            }

        }
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
        /// <summary>
        /// 泛型树节点类
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public class TNode<T>
        {
            //定义泛型数据
            private T value;
            public T Value
            {
                get { return value;}
                set { this.value = value; }
            }
            //泛型父节点
            private TNode<T> parent;
            public TNode<T> Parent
            {
                get { return parent; }
                set { parent = value; }
            }
            //泛型左子树节点
            private TNode<T> left;
            public TNode<T> Left
            {
                get { return left; }
                set { left = value; }
            }
            //泛型右子树节点
            private TNode<T> right;
            public TNode<T> Right
            {
                get { return right; }
                set { right = value; }
            }                        
        }
        public class Tree<T>
        {
            //定义树节点的总数,初始化为0
            private int count;
            public int Count
            {
                get { return count; }
                set { count = value; }
            }
            //定义树的根节点,初始化为空
            private TNode<T> root;
            public TNode<T> Root
            {
                get { return root; }
                set { root = value; }
            }
            //定义树的中序遍历
            public void Inorder_Tree_Walk(TNode<T> root)
            {               
                if (root != null)
                {
                    Inorder_Tree_Walk(root.Left);
                    Console.WriteLine(root.Value);
                    Inorder_Tree_Walk(root.Right);
                }               
            }
            //定义树的前序遍历
            public void Preorder_Tree_Walk(TNode<T> root)
            {
                if (root != null)
                {
                    Console.WriteLine(root.Value);
                    Preorder_Tree_Walk(root.Left);
                    Preorder_Tree_Walk(root.Right);
                }
            }
            //定义树的后序遍历
            public void Postorder_Tree_Walk(TNode<T> root)
            {
                if (root != null)
                {
                    Postorder_Tree_Walk(root.Left);
                    Postorder_Tree_Walk(root.Right);
                    Console.WriteLine(root.Value);
                }
            }
            public void Tree_Insert(TNode<T> node)
            {
                TNode<T> temp = this.Root;
                TNode<T> temp1 = null;
                while (temp != null)
                {
                    temp1 = temp;
                    if (node.Value < temp1.Value)
                    {

                    }
                }
            }
            public static bool operator < (TNode<T> node1,TNode<T> node2)
            {
                if (node1.Equals(node2))
                {
                    Equals()
                }
            } 
                
        }
        #endregion

    }
}
