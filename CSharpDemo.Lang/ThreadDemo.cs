using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace CSharpDemo.Lang
{
    class ThreadDemo
    {
        /// <summary>
        /// 开启一个线程
        /// </summary>
        public static void TestThread()
        {
            ThreadStart threadStart = new ThreadStart(() => { Console.WriteLine("hello."); });
            Thread t = new Thread(threadStart);
            t.Start();
        }
    }
}
