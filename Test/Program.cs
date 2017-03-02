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
            int[] array = new int[] { 5, 2, 4, 6, 1, 3 };
            int[] array11 = new int[] { 5, 13,2,2, 2, 25, 7, 17, 20, 8, 4 };
            int[] arr = new int[] { 15,15,15,15,15,15,15,15,15,15,15,15,15,15,14,13,12,11,10,9,8,7,6,5,4,3,2,1 };

            //int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            List<int> array1 = new List<int>() { 5, 2, 4, 6, 1, 3 };
            //////插入升序排序
            ////int[] result = IntroductionToAlgorithms.Sort.InsertSort(array);
            //int[] marray = new int[] { 4,2 };
            ////int[] result = IntroductionToAlgorithms.Sort.Merge(marray, 0, 0, 1);
            ////选择升序排序
            ////int[] result = IntroductionToAlgorithms.Sort.SelectionSort(array);

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

            int[,] a = new int[2, 6] { { 7,9,3,4,8,4}, {8,5,6,4,5,7 } };
            int[,] t = new int[2, 6] { {0, 2,3,1,3,4}, {0,2,1,2,2,1 } };
            int[] e = new int[2] { 2, 4 };
            int[] x = new int[2] { 3, 2 };
            int n = 6;
            List<int[,]> list =  Dynamic_Programming.Fastest_Way(a, t, e, x, n);
            Dynamic_Programming.Print_Station(list[1], 1, 6);
            Console.WriteLine("===========================");
            LinkedList<int> t11 = new LinkedList<int>();
            Linked_List<int> l = new Linked_List<int>();
            Node<int> a1 = new Node<int>(1);
            Node<int> a2 = new Node<int>(2);
            Node<int> a3 = new Node<int>(3);
            Node<int> a4 = new Node<int>(4);
            l.Insert(a1);
            l.Insert(a2);
            l.Insert(a3);
            l.Insert(a4);
            l.PrintList();
            Console.WriteLine("=======================");
            Console.WriteLine(Linked_List<int>.List_Search(l, 3).Node_Value.ToString());

            Console.WriteLine("==========================");
            string a11 = "abc";
            string b11 = "a";
            string c11 = "bc";
            string d11 = b11 + c11;
            Console.WriteLine(a11 == d11);
            Console.ReadKey();
        }
    }
}
