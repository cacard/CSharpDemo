using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace CSharpDemo.Lang.Threading
{
    public class ThreadBasic
    {
        /// <summary>
        /// 开启一个线程
        /// </summary>
        public static void TestThread()
        {
            // 不带参数的线程启动，ThreadStart委托
            ThreadStart threadStart = new ThreadStart(() => { Console.WriteLine("hello."); });
            Thread t = new Thread(threadStart);
            t.Start();

            // 带有参数的线程启动
            Thread t2 = new Thread((obj) => { Console.WriteLine(obj.ToString()); });
            t2.Start(new String('c',1));
        }
    }
}
