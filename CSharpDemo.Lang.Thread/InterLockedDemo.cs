/**
 * 原子操作
 * 
 * Java下有AtomicInteger/AtomicReference等
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using t = System.Threading.Thread;

namespace CSharpDemo.Lang.Threading
{
    public class InterLockedDemo
    {
        private static int count = 0;

        /// <summary>
        /// 多线程累加
        /// </summary>
        public static void testAtomicAdd()
        {
            int c=10;
            t[] tArray=new t[c];
            for (int i = 0; i < c; i++)
            {
                tArray[i] = new t(() => 
                {
                    Interlocked.Increment(ref count);// 多线程累加
                });
            }

            foreach(t _ in tArray)
            {
                _.Start();
            }

            foreach (t _ in tArray)
            {
                _.Join();
            }

            Console.WriteLine("->"+count);
        }
    }
}
