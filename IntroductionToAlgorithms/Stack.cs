using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToAlgorithms
{
    /// <summary>
    /// 00:00:00.0004319 c#内置Stack,push后pop10000的时间
    ///00:00:00.0018118  我自己实现的Stack时间，有待优化
    ///00:00:00.0036212  利用c#内置的泛型集合实现的类似内置Stack，速度确实最慢的
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// 利用数组存储数据
    public class Stack<T> where T : struct//（泛型数组Stack）
    {
        private int Top { get; set; }
        private int Length { get; set; }
        public T[] Stack_Value { get; set; }
        public Stack(int length)
        {
            this.Top = -1;
            this.Length = 0;
            Stack_Value = new T[length];
            this.Length = Stack_Value.Length;
        }
        public bool Stack_Empty()
        {
            if (this.Top != -1)
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
            if (this.Top == -1)
            {
                Console.WriteLine("There is no element in the stack");
                return default(T);
            }
            else
            {
                this.Top--;
                return this.Stack_Value[Top + 1];
            }
        }
        public void Push(T value)
        {
            this.Top++;
            if (this.Top == this.Length)
            {
                Console.WriteLine("Stack OverFlow");
            }
            else
            {
                this.Stack_Value[this.Top] = value;
            }
        }
        public T Peek()
        {
            if (this.Top != -1)
            {
                return this.Stack_Value[this.Top];

            }
            else
            {
                return default(T);
            }
        }
    }
    //利用List存储数据
    public class Stackk<T> where T : struct
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
        public T Peek()
        {
            return this.Stackk_Value[this.Stackk_Value.Count - 1];
        }
    }//（泛型集合Stack）


    //使用一个长度为n的数组来实现两个Stack，栈内元素不超过n个
    public class TwoStack<T> where T : struct
    {
        private int Left { get; set; }
        private int LeftCount { get; set; }
        private int Right { get; set; }
        private int RightCount { get; set; }
        private int Length { get; set; }
        public T[] Data { get; set; }

        public TwoStack(int length)
        {
            this.Left = -1;
            this.Right = length + 1;
            this.Data = new T[length];
        }
        public bool LeftStackEmpty()
        {
            return this.Left == -1 ? true : false;
        }
        public bool RightStackEmpty()
        {
            return this.Right == this.Length + 1 ? true : false;
        }

        public void LeftStackPush(T value)
        {
            if (this.Left + this.Right != this.Length)
            {
                this.Left++;
                this.LeftCount++;
                this.Data[this.Left] = value;
            }
            else
            {
                Console.WriteLine("The TwoStack is Full!");
            }
        }
        public void RightStackPush(T value)
        {
            if (this.Left + this.Right != this.Length)
            {
                this.Right--;
                this.RightCount++;
                this.Data[this.Right] = value;
            }
            else
            {
                Console.WriteLine("The Two Stack is Full!");
            }
        }
        public T LeftStackPop()
        {
            if (!LeftStackEmpty())
            {
                this.LeftCount--;
                T obj = this.Data[this.Left];
                this.Left--;
                return obj;
            }
            else
            {
                Console.WriteLine("The Left Stack is Empty!");
                return default(T);
            }
        }
        public T RightStackPop()
        {
            if (!RightStackEmpty())
            {
                this.RightCount--;
                T obj = this.Data[this.Right];
                this.Right++;
                return obj;
            }
            else
            {
                Console.WriteLine("The Right Stack is Empty!");
                return default(T);
            }

        }
        public T LeftStackPeek()
        {
            if (!LeftStackEmpty())
            {
                return this.Data[this.Left];
            }
            else
            {
                Console.WriteLine("The Left Stack is Empty!");
                return default(T);
            }
        }
        public T RightStackPeek()
        {
            if (!RightStackEmpty())
            {
                return this.Data[this.Right];
            }
            else
            {
                Console.WriteLine("The Right Stack is Empty!");
                return default(T);
            }
        }
    }

}
