using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToAlgorithms
{
    class Selection
    {
        #region 选择算法
        /// <summary>
        /// 返回数组最大值，时间O(n-1)
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static int Get_Max_Element(int[] array)
        {
            if (array.Length == 0)
            {
                Console.WriteLine("error");
                return -1;
            }
            else
            {
                int max = array[0];
                for (int i = 1; i < array.Length; i++)
                {
                    if (array[i] > max)
                    {
                        max = array[i];
                    }
                }
                return max;
            }
        }
        /// <summary>
        /// 返回数组最小值，时间O(n-1)
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static int Get_Min_Element(int[] array)
        {
            if (array.Length == 0)
            {
                Console.WriteLine("error");
                return -1;
            }
            else
            {
                int min = array[0];
                for (int i = 1; i < array.Length; i++)
                {
                    if (array[i] < min)
                    {
                        min = array[i];
                    }
                }
                return min;
            }
        }
        /// <summary>
        /// 返回数组最大最小值，两个元素比较三次，而不是一个元素比较两次
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static int[] Get_MaxAndMin_ELement(int[] array)
        {
            if (array.Length == 0)
            {
                Console.WriteLine("error");
                return new int[2] { -1, -1 };
            }
            else
            {
                int[] maxandmin; //= new int[2];

                if (array.Length % 2 == 0)
                {
                    maxandmin = array[0] > array[1] ? new int[2] { array[0], array[1] } : new int[2] { array[1], array[0] };
                    for (int i = 2; i < array.Length - 1; i += 2)
                    {
                        if (array[i] > array[i + 1])
                        {
                            if (array[i] > maxandmin[0])
                            {
                                maxandmin[0] = array[i];
                            }
                            if (array[i + 1] < maxandmin[1])
                            {
                                maxandmin[1] = array[i + 1];
                            }
                        }
                        else
                        {
                            if (array[i + 1] > maxandmin[0])
                            {
                                maxandmin[0] = array[i + 1];
                            }
                            if (array[i] < maxandmin[1])
                            {
                                maxandmin[1] = array[i];
                            }
                        }
                    }
                }
                else
                {
                    maxandmin = new int[2] { array[0], array[0] };
                    for (int i = 1; i < array.Length - 1; i += 2)
                    {
                        if (array[i] > array[i + 1])
                        {
                            if (array[i] > maxandmin[0])
                            {
                                maxandmin[0] = array[i];
                            }
                            if (array[i + 1] < maxandmin[1])
                            {
                                maxandmin[1] = array[i + 1];
                            }
                        }
                        else
                        {
                            if (array[i + 1] > maxandmin[0])
                            {
                                maxandmin[0] = array[i + 1];
                            }
                            if (array[i] < maxandmin[1])
                            {
                                maxandmin[1] = array[i];
                            }
                        }
                    }
                    return maxandmin;
                }
                return maxandmin;
            }

        }
        /// <summary>
        /// 随机选择第i个顺序统计量（即第i个在最小的元素）
        /// </summary>
        /// <param name="array"></param>
        /// <param name="p">数组初始下标</param>
        /// <param name="r">数组最末下标</param>
        /// <param name="i">第i个顺序元素</param>
        /// <returns></returns>
        public static int Randomized_Select(int[] array, int p, int r, int i)
        {
            if (p < r)
            {
                int q = Sort.Randomized_Partition(array, p, r);
                int value = q - p + 1;
                if (i == value)
                {
                    return array[q];
                }
                else if (i < value)
                {
                    return Randomized_Select(array, p, q - 1, i);
                    //return 0;
                }
                else
                {
                    return Randomized_Select(array, q + 1, r, i - value);
                    //return 0;
                }
            }
            else
            {
                Console.WriteLine("error");
                return -1;
            }

        }
        #endregion
    }

}

