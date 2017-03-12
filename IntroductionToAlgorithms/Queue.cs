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
}
