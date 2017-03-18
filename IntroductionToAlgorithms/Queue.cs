using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToAlgorithms
{
    //利用数组存储数据
    public class Queue<T>
    {
        public int Length { get; set; }
        private int Head { get; set; }
        private int Tail { get; set; }
       public T[] Queue_Value { get; set; }
        public Queue(int length)
        {
            this.Length = 0;
            this.Head = 0;
            this.Tail = 0;
            Queue_Value = new T[length];
        }
        public bool Queue_Empty()
        {
            if (this.Length == 0)
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
            if (Queue_Empty())
            {
                Queue_Value[this.Head] = value;
                this.Length++;
                Tail = (Tail + 1) % this.Queue_Value.Length;
            }
            else
            {
                if (this.Tail == this.Head && this.Length != 0)
                {
                    Console.WriteLine("The Queue is Full");
                }
                else
                {
                    Queue_Value[this.Tail] = value;
                    this.Length++;
                    Tail = (Tail + 1) % this.Queue_Value.Length;
                }
               
            }
        }
        public T DeQeue()
        {
            if (Queue_Empty())
            {
                Console.WriteLine("The Queue is Empty!");
                return default(T);
            }
            else
            {
                T result = this.Queue_Value[this.Head];
                this.Length--;
                this.Head = (this.Head + 1) % this.Queue_Value.Length;
                return result;
            }
        }
        
    }
}
