/**
 *  委托 Delegate
 *  
 *  1 自定义委托类型
 *  2 无返回值的框架自带委托类型 Action<>
 *  3 有返回值的框架自带委托类型 Func<>
 *  4 使用 lambda 表达式实现委托
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace CSharpDemo.Lang
{
    public delegate void Delegate1(String a,String b);

    public class DelegateDemo
    {
        public static void testDelegate()
        {
            Delegate1 delegate1 = someMethod;
            delegate1("String1", "String2");
        }

        private static void someMethod(String a, String b)
        {
            Console.WriteLine(String.Format("a:{0},b:{1}",a,b));
        }

        /// <summary>
        /// Action
        /// </summary>
        public static void testAction()
        {
            Action<String, String> action = someMethod;
            action("String1", "String2");

            // using lambda
            action = (x, y) => { Console.WriteLine("action using lambda"); };
            action("Str1", "Str2");
        }

        /// <summary>
        /// Action执行异步任务
        /// </summary>
        public static void testActionAsync()
        {
            Console.WriteLine("@main thread id is "+Thread.CurrentThread.ManagedThreadId);
            Action<int> actionAsync = (x) => { Console.WriteLine("@action's thread id is "+Thread.CurrentThread.ManagedThreadId+"/x is "+x); };
            actionAsync.BeginInvoke(1, (y) => { Console.WriteLine("@callback"); }, null);

            Thread.Sleep(2000);//等待异步线程执行结束
        }

        /// <summary>
        /// Func
        /// </summary>
        public static void testFunc()
        {
            Func<Int32, int, int> func = (x, y) => { return x + y; };
            int result = func(1, 2);
            Console.WriteLine("func result is "+result);
        }
    }
}
