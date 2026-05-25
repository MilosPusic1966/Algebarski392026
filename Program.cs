using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algebarski392026
{
    internal class Program
    {
        static int[] p;
        static int st;
        static public int nadji(int x)
        {
            for (int i = 0; i<st; i++)
            {
                if (p[i] == x) return i;
            }
            return -1;
        }
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            p = new int[50];
            int[] s = new int[50];
            st = -1;
            int k = 2;
            while (n > 1)
            {
                Console.WriteLine( "n={0}",n);
                if ((n % k) == 0)
                {
                    int poz = nadji(k);
                    if (poz > -1)
                    {
                        s[poz]++;
                        Console.WriteLine("s={0}  poz={1}", s, poz);
                    }
                    else
                    {
                        st++;
                        p[st] = k;
                        s[st] = 1;
                        Console.WriteLine("s={0}  st={1}", s, st);
                    }
                    n = n / k;
                }
                else k++;
            }
            for (int i = 0; i < st; i++)
            {
                Console.WriteLine("{0} {1}", p[i], s[i]);
            }
        }
    }
}
