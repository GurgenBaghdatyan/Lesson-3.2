using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lesson_3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n,count=1, s=0,n1,k;
            decimal t;
            Console.Write("n = ");
            n = Convert.ToInt32(Console.ReadLine());
            n1 = n;
            while (n/10>1)
            {
                n /= 10;
                count++;
            }
            double[] a=new double[Convert.ToInt32(count)];
            
            Console.WriteLine(count);
            n = n1;
            for (double i = count; i  >0; i--)
            {
               
                t = Convert.ToDecimal(n / Math.Pow(10, i-1));
                k= Convert.ToDouble(decimal.Truncate(t));
                s += k;
                n -= k* Math.Pow(10, i - 1);
            }
            Console.WriteLine(s);
            s = 1;
            n = n1;
            for (double i = count; i > 0; i--)
            {

                t = Convert.ToDecimal(n / Math.Pow(10, i - 1));
                k = Convert.ToDouble(decimal.Truncate(t));
                s *= k;
                n -= k * Math.Pow(10, i - 1);
            }
            Console.WriteLine(s);
            n = n1;
            int nish;
            for (double i = count , j=0; i > 0; i--,j++)
            {
                t = Convert.ToDecimal(n / Math.Pow(10, i - 1));
                nish = Convert.ToInt32(decimal.Truncate(t));
                Console.Write(nish + " ");
                a[Convert.ToInt32(j)] = nish;
                n -= nish*Math.Pow(10, i - 1);
            }
            Console.WriteLine();
            for (double i = count-1 ;i>-1 ;i--)
            {
                Console.Write(a[Convert.ToInt32(i)]+" ");
            }
            s = 0;
            Console.WriteLine("\n");
            for (double i=count-1 ;i>-1 ;i--)
            {
                s+=Math.Pow(10, i)*a[Convert.ToInt32(i)];
            }
            Console.WriteLine(s);
            bool b = false;
            Console.WriteLine("\n");
            for (double i = count - 1; i > -1; i--)
            {
                if(a[Convert.ToInt32(i)]==2)
                {
                    b = true; 
                    break;
                }
            }
            Console.WriteLine(b);
            b= false;
            Console.WriteLine("\n");
            for (double i = count - 1; i > 0; i--)
            {
                if (a[Convert.ToInt32(i)]==a[Convert.ToInt32(i)])
                {
                    b = true; 
                    break;
                }
            }
            b= false;
            Console.WriteLine(b);
            Console.WriteLine("\n");
            for (double i = count - 1; i > -1; i--)
            {
                if (a[Convert.ToInt32(i)]%2==1)
                {
                    b = true;
                    break;
                }
            }
            Console.WriteLine(b);
            double s1=0;
            s = 0;
            b = false;
            Console.WriteLine("\n");
            for (double i = count - 1; i > -1; i--)
            {
                if (Convert.ToInt32(i)%2==1)
                {
                    s1 += a[Convert.ToInt32(i)];
                }
                else s += a[Convert.ToInt32(i)];
            }
            if (s==s1) b=true;
            Console.WriteLine(b);
            Console.ReadKey();
        }
    }
}
