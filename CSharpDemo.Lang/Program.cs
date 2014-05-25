using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CSharpDemo.Lang.Threading;
using CSharpDemo.Lang.Collection.Concurrent;

namespace CSharpDemo.Lang
{
    class Program
    {
        static void Main(string[] args)
        {
            CollectionConcurrentTest();
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

        private static void CollectionConcurrentTest()
        {
            //BlockingCollectionDemo.Test();
            ConcurrentBagDemo.Test();
        }
    }
}
