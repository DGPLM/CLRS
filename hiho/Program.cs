using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hiho
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] a = Console.ReadLine().Split();
            string b = Console.ReadLine();
            int value = Convert.ToInt32(a[0]);
            int m = Convert.ToInt32(a[1]);


            string s = Book(b, value, m);
            Console.WriteLine(s);
            // Console.ReadKey();
        }

        public static string Book(string s, int value, int m)
        {
            int row = 0;
            int col = 0;
            int temp = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (i % (m - 1) == 0)//到达边界
                {
                    if (s[i] == ' ')
                    {
                        row++;
                        
                    }
                    else
                    {
                        if (s[i + 1] == ' ')
                        {
                            row++;
                            
                        }
                        else
                        {
                            while (i>0 && s[i] != ' ')
                            {
                                i--;
                                temp++;
                            }
                            row++;
                            
                        }
                       
                    }
                    
                }
                while (value > 1)
                {
                    if (i + 1 == s.Length + temp)
                    {
                        col = i % (m - 1);
                        if (col == 0)
                        {
                            row = row * (value - 1);
                            break;
                        }
                        else
                        {
                            int tt = m - col - 1;
                            if (s[tt] == ' ')
                            {
                                row++;
                                i = tt;
                            }
                            else
                            {
                                if (s[tt + 1] == ' ')
                                {
                                    row++;
                                    i = tt;
                                }
                                else
                                {
                                    while (tt>0&&s[tt] != ' ')
                                    {
                                        tt--;
                                        temp++;
                                    }
                                    row++;
                                    i = tt;
                                }
                            }

                        }

                    }
                    value--;
                }


            }
            string res = row.ToString() + " " + col.ToString();
            return res;
        }

    }
}
