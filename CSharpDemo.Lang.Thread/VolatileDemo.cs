/**
 * Volatile变量
 * 
 * 对volatile变量的写，对其他变量是立即可见的；
 * 对volatile变量的读，能够保证读取的是最新值。
 * 不保证线程安全。
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace CSharpDemo.Lang.Threading
{
    public class VolatileDemo
    {
        private static volatile int count = 0;

        public static void TestVolatile()
        {
            int c = 1000;
            Thread[] ts = new Thread[c];
            for (int i = 0; i < c; i++)
            {
                ts[i] = new Thread(() => {
                    count = count +3; 
                });
            }

            foreach (Thread t in ts)
            {
                t.Start();
            }

            foreach (Thread t in ts)
            {
                t.Join();
            }

            Console.WriteLine("->"+count);
        }
    }
}
