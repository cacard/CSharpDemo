/**
 * BlockingCollection 线程安全的阻塞集合
 * Java下面有BlockingQueue
 * 一般用作线程生产/消费队列
 * 
 * 特点：
 * 有界
 * 线程阻塞
 * 可指定数据结构类型（IProducterConsumerCollection），默认是ConcurrentQueue<T>.
 * 
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.Concurrent;
using System.Threading;

namespace CSharpDemo.Lang.Collection.Concurrent
{
    public class BlockingCollectionDemo
    {
        public static void Test()
        {
            BlockingCollection<int> bc = new BlockingCollection<int>(5); // 有界
            BlockingCollection<int> bc2 = new BlockingCollection<int>(new ConcurrentStack<int>()/*指定类型，必须是IProducterConsumerCollection的实现*/, 5);

            // productor
            new Thread(() =>
            {
                for (int i = 0; i < 100; i++)
                {
                    bc.Add(i); Console.WriteLine("bc.Add(" + i + ");");
                }
            }).Start();

            // consumer
            new Thread(() =>
            {
                Console.WriteLine("->consumer:");
                int c = 1;
                while (Console.ReadLine() != "EOF")
                {
                    Console.WriteLine("bc.Take():" + bc.Take());
                }
            }).Start();


            // 释放#1
            try
            {
                bc.Dispose();
            }
            catch (Exception e)
            {
                throw;
            }

            // 释放#2
            using (BlockingCollection<int> _bc = new BlockingCollection<int>())
            {

            }

        }
    }
}
