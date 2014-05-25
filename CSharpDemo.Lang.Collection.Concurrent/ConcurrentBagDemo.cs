/**
 * ConcurrentBag
 * 
 * 虽然没有Bag这种数据结构，但其含义是无序的、可重复的集合。
 * ConcurrentBag是线程的安全的Bag。
 * 
 * Using:
 * Add() 添加元素
 * TryTake() 非阻塞的取出元素，并返回是否成功取出。
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.Concurrent;
using System.Threading;

namespace CSharpDemo.Lang.Collection.Concurrent
{
    public class ConcurrentBagDemo
    {
        public static void Test()
        {
            ConcurrentBag<int> cb = new ConcurrentBag<int>();

            new Thread(() => { for (int i = 0; i < 100; i++) {
                Thread.Sleep(1000);
                cb.Add(i); } }).Start();

            new Thread(() =>
            {
                while (true)
                {
                    int o = 0;
                    bool b = cb.TryTake(out o);
                    if (b)
                    {
                        Console.WriteLine("consumer->" + o);
                    }
                    else
                    {
                        Console.WriteLine("consumer tryTake false");
                    }

                    Thread.Sleep(300);
                }
            }).Start();
        }
    }
}
