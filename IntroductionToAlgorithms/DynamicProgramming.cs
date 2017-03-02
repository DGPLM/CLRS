using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToAlgorithms
{
    public class DynamicProgramming
    {
        public static List<int[,]> Fastest_Way(int[,] a, int[,] t, int[] e, int[] x, int n)
        {
            int[,] f = new int[2, n + 1];
            int[,] l = new int[2, n + 1];
            f[0, 0] = a[0, 0] + e[0]; //装配线一的初始时间
            f[1, 0] = a[1, 0] + e[1]; //装配线二的初始时间

            for (int i = 1; i < n; i++)
            {
                //处理装配线一
                if (f[0, i - 1] + a[0, i] < f[1, i - 1] + t[1, i] + a[0, i])
                {
                    f[0, i] = f[0, i - 1] + a[0, i];
                    l[0, i] = 1;
                }
                else
                {
                    f[0, i] = f[1, i - 1] + t[1, i] + a[0, i];
                    l[0, i] = 2;
                }
                //处理装配线二
                if (f[1, i - 1] + a[1, i] < f[0, i - 1] + t[0, i] + a[1, i])
                {
                    f[1, i] = f[1, i - 1] + a[1, i];
                    l[1, i] = 2;
                }
                else
                {
                    f[1, i] = f[0, i - 1] + t[0, i] + a[1, i];
                    l[1, i] = 1;
                }
            }
            //处理出口处时间
            if (f[0, n - 1] + x[0] < f[1, n - 1] + x[1])
            {
                f[0, n] = f[0, n - 1] + x[0];
                f[1, n] = 1;
            }
            else
            {
                f[0, n] = f[1, n - 1] + x[1];
                f[1, n] = 2;
            }
            List<int[,]> list = new List<int[,]>();
            list.Add(f);
            list.Add(l);

            return list;
        }
        public static void Print_Station(int[,] l, int ltime, int n)
        {
            int i = ltime - 1;
            Console.WriteLine("Line {0} ,Station {1}", i + 1, n);
            for (int j = n - 1; j > 0; j--)
            {
                i = l[i, j] - 1;
                Console.WriteLine("Line {0} ,Station {1}", i + 1, j);
            }
        }
    }
}
