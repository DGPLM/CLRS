using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IntroductionToAlgorithms;
using System.Timers;
using System.Diagnostics;

namespace Test
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] array11 = new int[] { 5, 13, 2, 2, 2, 25, 7, 17, 20, 8, 4,25,4 };
            Console.WriteLine("Before:" + array11.Length);
            foreach (var item in array11)
            {
                Console.Write(item);
                Console.Write(" ");
            }
            // int[] array = new int[] { 5, 2, 4, 6, 1, 3 };
            
            //int[] arr = new int[] { 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 14, 13, 12, 11, 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };

            //int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            //List<int> array1 = new List<int>() { 5, 2, 4, 6, 1, 3 };
            //////插入升序排序
            ////int[] result = IntroductionToAlgorithms.Sort.InsertSort(array);
            //int[] marray = new int[] { 4,2 };
            ////int[] result = IntroductionToAlgorithms.Sort.Merge(marray, 0, 0, 1);
            //选择升序排序
            int[] result = IntroductionToAlgorithms.Sort.Select(array11);
           
            Console.WriteLine();
            foreach (int item in result)
            {                
                Console.Write(item);
                Console.Write(" ");
            }
            Console.WriteLine();
            Console.WriteLine("After:"+result.Length);
            //int[] result = IntroductionToAlgorithms.Sort.MergeSort(array, 0, 5);
            //foreach (int item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //Stopwatch t = new Stopwatch();

            //t.Start();
            ////Stack<int> s = new Stack<int>(5)
            //IntroductionToAlgorithms.Stackk<int> s = new IntroductionToAlgorithms.Stackk<int>(5);
            //for (int i = 0; i < 10000; i++)
            //{
            //   s.Push(i);
            //}
            //for (int i = 0; i < 10000; i++)
            //{
            //    s.Pop();
            //}
            //t.Stop();
            //Console.WriteLine(t.Elapsed);

            #region DP
            //int[,] a = new int[2, 6] { { 7,9,3,4,8,4}, {8,5,6,4,5,7 } };
            //int[,] t = new int[2, 6] { {0, 2,3,1,3,4}, {0,2,1,2,2,1 } };
            //int[] e = new int[2] { 2, 4 };
            //int[] x = new int[2] { 3, 2 };
            //int n = 6;
            ////List<int[,]> list =  Dynamic_Programming.Fastest_Way(a, t, e, x, n);
            ////Dynamic_Programming.Print_Station(list[1], 1, 6);
            ////Console.WriteLine("===========================");
            ////LinkedList<int> t11 = new LinkedList<int>();
            ////Linked_List<int> l = new Linked_List<int>();
            ////Node<int> a1 = new Node<int>(1);
            ////Node<int> a2 = new Node<int>(2);
            ////Node<int> a3 = new Node<int>(3);
            ////Node<int> a4 = new Node<int>(4);
            //l.Insert(a1);
            //l.Insert(a2);
            //l.Insert(a3);
            //l.Insert(a4);
            //l.PrintList();
            //Console.WriteLine("=======================");
            //Console.WriteLine(Linked_List<int>.List_Search(l, 3).Node_Value.ToString());
            #endregion
            #region Queue 
            //Output:
            //The Queue is Full
            //Second
            //Third
            //Fiveth
            //Fifth
            //Sixth
            //IntroductionToAlgorithms.Queue<string> queue = new IntroductionToAlgorithms.Queue<string>(5);
            //queue.Enqueue("First");
            //queue.Enqueue("Second");
            //queue.Enqueue("Third");
            //queue.Enqueue("Fiveth");
            //queue.Enqueue("Fifth");
            //queue.Enqueue("Sixth");
            //queue.DeQeue();
            //queue.Enqueue("Sixth");
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine(queue.DeQeue());
            //}

            #endregion
            #region Stack
            //Output:
            //5
            //5
            //4
            //The Stack is Full
            //6
            //4
            //3
            //2
            //1
            //IntroductionToAlgorithms.Stack<int> stack = new IntroductionToAlgorithms.Stack<int>(5);
            //for (int i = 0; i < 5; i++)
            //{
            //    stack.Push(i + 1);
            //}
            //Console.WriteLine(stack.Peek());
            //Console.WriteLine(stack.Pop());
            //Console.WriteLine(stack.Peek());
            //stack.Push(6);
            //stack.Push(7);
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine(stack.Pop());

            //}

            //IntroductionToAlgorithms.Stackk<int> stack = new IntroductionToAlgorithms.Stackk<int>(5);
            //for (int i = 0; i < 5; i++)
            //{
            //    stack.Push(i + 1);
            //}
            //Console.WriteLine(stack.Peek());
            //Console.WriteLine(stack.Pop());
            //Console.WriteLine(stack.Peek());
            //stack.Push(6);
            //stack.Push(7);
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine(stack.Pop());

            //}
            #endregion
            #region
            //Linked_List<string> list = new Linked_List<string>();
            //LNode<string> a1 = new LNode<string>("1");
            //LNode<string> a2 = new LNode<string>("2");
            //LNode<string> a3 = new LNode<string>("3");
            //LNode<string> a4 = new LNode<string>("4");
            //list.HeadInsert(a1);
            //list.HeadInsert(a2);
            //list.HeadInsert(a3);
            //list.HeadInsert(a4);
            //list.PrintList();
            ////Output:4 3 2 1
            //list.Clear();
            //list.TailInsert(a1);
            //list.TailInsert(a2);
            //list.TailInsert(a3);
            //list.TailInsert(a4);
            //list.PrintList();
            ////Output:1 2 3 4
            //list.Delete(a3);
            //list.PrintList();
            //Output:1 2 4

            #endregion

            

            Console.ReadKey();
        }
    }
}
