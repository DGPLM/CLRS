using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToAlgorithms
{
    #region 排序算法
    public class Sort
    {
        /// <summary>
        /// 插入升序排序
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static int[] InsertSort(int[] array)
        {
            int[] result = new int[array.Length];
            int key;//用来存放当前数值
            int j;
            result[0] = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                key = array[i];
                j = i - 1;
                while ((j >= 0) && (result[j] > key))//利用while循坏调整位置
                {
                    result[j + 1] = result[j];
                    j = j - 1;
                }
                result[j + 1] = key;

            }
            return result;
        }
        /// <summary>
        /// 选择升序排序
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static int[] SelectionSort(int[] array)
        {
            int position = 0;//标记数组最小值下标
            int min = array[0];//数组最小值，初始化为数组第一个数字
            for (int i = 0; i < array.Length - 1; i++)//外层for循环用来确定当前选择最小值放置到哪个位置，因此只需要到length - 1
            {
                for (int j = i; j < array.Length; j++)//内层for循环用来确定未排序部分数组的最小值，因此次数为length
                {
                    if (array[j] < min)
                    {
                        min = array[j];
                        position = j;
                    }
                }
                array[position] = array[i];//更新已排序部分
                array[i] = min;
                position = i + 1;//更新最小值已经最小值坐标
                min = array[position];
            }
            return array;
        }
        //public static int[] MergeSort(int[] array, int l, int r)
        //{
        //    int m = 0;
        //    if (l < r)
        //    {
        //        m = (l + r) / 2;
        //        MergeSort(array, l, m);
        //        MergeSort(array, m + 1, r);
        //        Merge(array, l, m, r);
        //    }
        //    return array;



        //public static int[] Merge(int[] array,int l,int m,int r)
        //{
        //    int L_length = m - l + 1;
        //    int R_length = r - m;
        //    int[] L_array = new int[L_length];
        //    int[] R_array = new int[R_length];
        //    int i ;
        //    int j ;
        //    for ( i = 0; i < L_length; i++)
        //    {
        //        L_array[i] = array[l+i];
        //    }
        //    for (j = 0; j < R_length; j++)
        //    {
        //        R_array[j] = array[m + 1 + j];
        //    }
        //    i = 0;
        //    j = 0;
        //    for (int k = l; k < r+1; k++)
        //    {
        //        if (i >= L_length && j >= R_length)
        //        {
        //            break;
        //        }
        //        if (i == L_length)
        //        {
        //            while (j < R_length)
        //            {
        //                array[k] = R_array[j];
        //                j++;
        //            }
        //            break;
        //        }
        //        if (j == R_length)
        //        {
        //            while (i < L_length)
        //            {
        //                array[k] = L_array[i];
        //                i++;
        //            }
        //            break;
        //        }
        //        if (L_array[i] < R_array[j])
        //        {
        //            array[k] = L_array[i];
        //            i++;
        //        }
        //        else
        //        {
        //            array[k] = R_array[j];
        //            j++;
        //        }


        //    }
        //    return array;
        //}
        public static int[] MergeSort(int[] array, int l, int r)
        {
            int q = 0;
            if (l < r)
            {
                q = (l + r) / 2;
                array = MergeSort(array, l, q);
                array = MergeSort(array, q + 1, r);
                array = Merge(array, l, q, r);
            }

            return array;

        }
        /// <summary>
        /// 合并排序的辅助函数
        /// </summary>
        /// <param name="array"></param>
        /// <param name="p"></param>
        /// <param name="q"></param>
        /// <param name="r"></param>
        /// <returns></returns>
        public static int[] Merge(int[] array, int l, int m, int r)
        {
            int L_length = m - l + 1; //定义左边数组长度
            int R_length = r - m;  //定义右边数组长度
            int[] L_array = new int[L_length];
            int[] R_array = new int[R_length];
            int i; //定义辅助左辅助坐标
            int j; //定义辅助右辅助坐标
            for (i = 0; i < L_length; i++)
            {
                L_array[i] = array[l + i];
            }
            for (j = 0; j < R_length; j++)
            {
                R_array[j] = array[m + 1 + j];
            }
            i = 0;
            j = 0;//将左右坐标辅以初始值

            for (int k = l; k <= r; k++)
            {
                if (i >= L_length && j >= R_length) //当辅助坐标达到最末端则跳出循环
                {
                    break;
                }
                if (i == L_length)
                {
                    while (j < R_length)
                    {
                        array[k] = R_array[j]; //当左辅助坐标达到最末端则继续将右数组赋值到排序数组中
                        j++;
                    }
                    break;

                }
                if (j == R_length)
                {
                    while (i < L_length)
                    {
                        array[k] = L_array[i]; //当右辅助坐标达到最末端则继续将左数组赋值到排序数组中
                        i++;
                    }
                    break;

                }
                if (L_array[i] < R_array[j])  //核心排序算法，比较左右辅助数组，赋值较小的一个
                {
                    array[k] = L_array[i];
                    i++;
                }
                else
                {
                    array[k] = R_array[j];
                    j++;
                }
            }
            return array;

        }

        class Heap
        {
            int length; //定义堆数组的长度

            int heap_size; //定义堆中元素个数

            // int[] Heap_array; //定义存放堆元素的数组
            List<int> Heap_array = new List<int>();
            public Heap(List<int> Heap_element) //定义堆的构造函数
            {
                this.length = Heap_element.Count;
                this.heap_size = this.length;
                Heap_array = Heap_element;
            }
            public void Show_Heap_Element()
            {
                if (this.heap_size == 0)
                {
                    Console.WriteLine("error");
                }
                else
                {
                    for (int i = 0; i < heap_size; i++)
                    {
                        Console.WriteLine("The {0} element in the heap is  {1}", i, this.Heap_array[i]);
                    }
                }
            }
            public int Return_L_Childpos(int node_pos) //返回对应堆节点的左子树坐标
            {
                if (node_pos < 0 || node_pos >= this.heap_size)
                {
                    Console.WriteLine("error");
                    return -1;
                }
                else
                {
                    return (node_pos + 1) * 2 - 1;
                }

            }
            public int Return_R_Childpos(int node_pos) //返回对应堆节点的右子树坐标
            {
                if (node_pos < 0 || node_pos >= this.heap_size)
                {
                    Console.WriteLine("error");
                    return -1;
                }
                else
                {
                    return (node_pos + 1) * 2;
                }
            }
            public int Return_Parentspos(int node_pos) //返回对应堆节点的父结点坐标
            {
                if (node_pos < 0 || node_pos >= this.heap_size)
                {
                    Console.WriteLine("error");
                    return -1;
                }
                else
                {
                    if (node_pos % 2 == 0)
                    {
                        return (node_pos - 1) / 2;
                    }
                    else
                    {
                        return node_pos / 2;

                    }
                }
            }
            public int Return_Last_Treenodepos() //返回指定堆的最后一个树节点,用于创建最大、最小堆
            {

                if (this.heap_size == 1)
                {
                    return 1;
                }
                else
                {
                    return (this.heap_size - 2) / 2;
                }

            }
            public int Return_Height() //返回当前堆的高度，以e为底，并不准确
            {
                return Convert.ToInt32(Math.Log((double)this.heap_size));
            }
            /// <summary>
            /// 使对应堆节点处保持最大堆性质
            /// </summary>
            /// <param name="heap">对应的堆数据结构</param>
            /// <param name="node">对应的堆节点</param>
            /// <returns></returns>
            public static Heap Max_Heapify(Heap heap, int node)
            {
                int biggest_pos;
                if (node < 0 || node >= heap.heap_size)
                {
                    Console.WriteLine("error");
                    return null;
                }
                else
                {
                    int l_pos = heap.Return_L_Childpos(node);
                    int r_pos = heap.Return_R_Childpos(node);
                    if (l_pos < heap.heap_size && heap.Heap_array[l_pos] > heap.Heap_array[node])
                    {
                        biggest_pos = l_pos;
                    }
                    else
                    {
                        biggest_pos = node;
                    }
                    if (r_pos < heap.heap_size && heap.Heap_array[r_pos] > heap.Heap_array[biggest_pos])
                    {
                        biggest_pos = r_pos;
                    }
                    if (biggest_pos == node)
                    {
                        return heap;
                    }
                    else
                    {
                        int temp = heap.Heap_array[node];
                        heap.Heap_array[node] = heap.Heap_array[biggest_pos];
                        heap.Heap_array[biggest_pos] = temp;
                        Max_Heapify(heap, biggest_pos);
                    }
                    return heap;
                }

            }
            /// <summary>
            /// 将当前指定堆,构造为最大堆
            /// </summary>
            /// <param name="heap"></param>
            /// <returns></returns>                            
            public static Heap Build_Max_Heap(Heap heap)
            {
                heap.heap_size = heap.length;
                int last_tree = heap.Return_Last_Treenodepos();
                for (int i = last_tree; i >= 0; i--)
                {
                    heap = Max_Heapify(heap, i);
                }
                return heap;
            }
            public static Heap Heap_Sort_de(Heap heap) //堆排序
            {
                heap = Build_Max_Heap(heap);
                int len = heap.length - 1;
                for (int i = len; i > 0; i--)
                {
                    int temp = heap.Heap_array[i];
                    heap.Heap_array[i] = heap.Heap_array[0];
                    heap.Heap_array[0] = temp;
                    heap.heap_size--;
                    heap = Max_Heapify(heap, 0);
                }
                heap.heap_size = heap.length;
                return heap;
            }
            /// <summary>
            /// 使对应堆节点处保持最小堆性质
            /// </summary>
            /// <param name="heap"></param>
            /// <param name="node"></param>
            /// <returns></returns>
            public static Heap Min_Heapify(Heap heap, int node)
            {
                int smallest_pos = 0;
                if (node < 0 || node >= heap.heap_size)
                {
                    Console.WriteLine("error");
                    return null;
                }
                else
                {
                    int lpos = heap.Return_L_Childpos(node);
                    int rpos = heap.Return_R_Childpos(node);
                    if (lpos < heap.heap_size && heap.Heap_array[lpos] < heap.Heap_array[node])
                    {
                        smallest_pos = lpos;
                    }
                    else
                    {
                        smallest_pos = node;
                    }
                    if (rpos < heap.heap_size && heap.Heap_array[rpos] < heap.Heap_array[smallest_pos])
                    {
                        smallest_pos = rpos;
                    }
                    if (smallest_pos == node)
                    {
                        return heap;
                    }
                    else
                    {
                        int temp = heap.Heap_array[smallest_pos];
                        heap.Heap_array[smallest_pos] = heap.Heap_array[node];
                        heap.Heap_array[node] = temp;
                        Min_Heapify(heap, smallest_pos);
                    }
                    return heap;

                }
            }
            /// <summary>
            /// 将当前指定堆，构造为最小堆
            /// </summary>
            /// <param name="heap"></param>
            /// <returns></returns>
            public static Heap Build_Min_Heap(Heap heap)
            {
                heap.heap_size = heap.length;
                int len = heap.Return_Last_Treenodepos();
                for (int i = len; i >= 0; i--)
                {
                    Min_Heapify(heap, i);
                }
                return heap;
            }
            public static Heap Heap_Sort_in(Heap heap)
            {
                heap = Build_Min_Heap(heap);
                int len = heap.length - 1;
                for (int i = len; i > 0; i--)
                {
                    int temp = heap.Heap_array[i];
                    heap.Heap_array[i] = heap.Heap_array[0];
                    heap.Heap_array[0] = temp;
                    heap.heap_size--;
                    heap = Min_Heapify(heap, 0);
                }
                heap.heap_size = heap.length;
                return heap;
            }
            public static int Maximum(Heap heap)
            {
                if (heap.heap_size < 0)
                {
                    Console.WriteLine("The Heap is empty");
                    return -1;
                }
                else
                {
                    return heap.Heap_array[0];
                }
            }

        }
        /// <summary>
        /// 改进后递增快速排序
        /// </summary>
        /// <param name="array"></param>
        /// <param name="p">数组初始坐标</param>
        /// <param name="r">数组最末坐标</param>
        /// <returns></returns>
        public static int[] QuickSort(int[] array, int p, int r)
        {
            if (p < r)
            {
                int q = Partition(array, p, r);
                QuickSort(array, p, q - 1);
                QuickSort(array, q + 1, r);

            }
            else
            {
                return array;
            }
            return array;
        }
        /// <summary>
        /// 递增快速排序辅助方法
        /// </summary>
        /// <param name="array"></param>
        /// <param name="p"></param>
        /// <param name="r"></param>
        /// <returns></returns>
        public static int Partition(int[] array, int p, int r)
        {
            int middle_value = array[r];
            int i = p - 1;//用i来指示比中间值大的元素的数组下标
            int temp;
            for (int j = p; j < r; j++)//用j来指示比中间值小的元素的数组下标
            {
                if (array[j] < middle_value)
                {
                    i++;
                    temp = array[i];//通过i++后，指向可以更换的元素下标，更换两个元素
                    array[i] = array[j];
                    array[j] = temp;
                }
            }
            temp = array[i + 1];//最后将中间值移动“中间”
            array[i + 1] = array[r];
            array[r] = temp;
            return i + 1;//返回中间值最后的下标

        }
        public static int[] Randomized_QuickSort(int[] array, int p, int r)
        {
            if (p < r)
            {
                int q = Randomized_Partition(array, p, r);
                Randomized_QuickSort(array, p, q - 1);
                Randomized_QuickSort(array, q + 1, r);
            }
            else
            {
                return array;
            }
            return array;
        }
        /// <summary>
        /// 随机快速排序辅助方法
        /// </summary>
        /// <param name="array"></param>
        /// <param name="p"></param>
        /// <param name="r"></param>
        /// <returns></returns>
        public static int Randomized_Partition(int[] array, int p, int r)
        {
            Random ran = new Random();
            int value = ran.Next(p, r);
            int temp = array[value];
            array[value] = array[r];
            array[r] = temp;
            return Partition(array, p, r);
        }
        /// <summary>
        /// 原始Hoare快速递增排序，区别在于辅助方法
        /// </summary>
        /// <param name="array"></param>
        /// <param name="p"></param>
        /// <param name="r"></param>
        /// <returns></returns>
        public static int[] Hoare_QuickSort(int[] array, int p, int r)
        {
            if (p < r)
            {
                int q = Hoare_Partition(array, p, r);
                QuickSort(array, p, q - 1);
                QuickSort(array, q + 1, r);
            }
            else
            {
                return array;
            }
            return array;
        }
        public static int Hoare_Partition(int[] array, int p, int r)
        {
            int middle_value = array[r];
            int i = p - 1;
            int j = r + 1;
            while (true)
            {
                j--;
                while (j >= 0 && !(array[j] < middle_value))//检查边界情况
                {
                    j--;
                }
                i++;
                while (i <= r && !(array[i] > middle_value))
                {
                    i++;
                }
                if (i < j)
                {
                    int temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
                else
                {
                    return j;
                }
            }
        }
        #region 线性时间排序
        /// <summary>
        /// 递增计数排序
        /// </summary>
        /// <param name="Aarray"></param>
        /// <param name="Barray"></param>
        /// <param name="max_value"></param>
        /// <returns></returns>
        public static int[] Counting_Sort(int[] Aarray, int[] Barray, int max_value)
        {
            int[] Carray = new int[max_value + 1];//创建临时储存数组，用来储存每个元素的个数
            for (int i = 0; i < Carray.Length; i++)//将临时储存数组的每个值赋予0，代表该下标的元素数量为0
            {
                Carray[i] = 0;
            }
            for (int i = 0; i < Aarray.Length; i++)//统计每个元素的个数
            {
                Carray[Aarray[i]]++;
            }
            for (int i = 1; i < Carray.Length; i++)//通过累加前一个下标的值计算在排序后数组中该元素实际位置
            {
                Carray[i] = Carray[i] + Carray[i - 1];

            }
            for (int i = 0; i < Carray.Length; i++)//自减一求得实际数组下标
            {
                Carray[i]--;
            }
            //for (int i = 0; i < Aarray.Length; i++)
            //{
            //    Barray[Carray[Aarray[i]]] = Aarray[i];
            //    Carray[Aarray[i]]--;
            //}
            //此处使用倒序，目的是确保相对位置的准确,原先在前的元素依然在前,确保排序的稳定性
            for (int i = Aarray.Length - 1; i >= 0; i--)
            {
                Barray[Carray[Aarray[i]]] = Aarray[i];
                Carray[Aarray[i]]--;
            }

            return Barray;
        }
        #endregion
        #endregion
    }

}

