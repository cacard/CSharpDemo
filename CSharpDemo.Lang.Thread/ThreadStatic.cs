/**
 * 线程本地变量
 * 
 * Java下的ThreadLocal
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace CSharpDemo.Lang.Threading
{
    public class ThreadStatic
    {
        [ThreadStatic]
        private static int threadLocalValue = 1;

        /// <summary>
        /// 每个线程的ThreadLocal变量相互不影响。
        /// </summary>
        public static void testThreadStatic()
        {
            for (int i = 0; i < 10; i++)
            {
                Thread t = new Thread(() => { 
                    Console.WriteLine("@thread:"+Thread.CurrentThread.ManagedThreadId+",threadLocalValue:"+threadLocalValue);
                    threadLocalValue++;
                });
                t.Start();
            }
        }
    }
}
