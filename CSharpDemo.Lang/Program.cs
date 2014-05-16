using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CSharpDemo.Lang.Threading;

namespace CSharpDemo.Lang
{
    class Program
    {
        static void Main(string[] args)
        {
            ThreadDemoTest();
        }

        private static void DelegateDemoTest()
        {
            DelegateDemo.testDelegate();
            DelegateDemo.testAction();
            DelegateDemo.testFunc();
            DelegateDemo.testActionAsync();
        }

        private static void ThreadDemoTest()
        {
            //ThreadStatic.testThreadStatic();
            //InterLockedDemo.testAtomicAdd();
            VolatileDemo.TestVolatile();
        }

    }
}
