/**
 * ArrayList
 * 
 * SyncArrayList
 * FixSizeArrayList
 * ReadOnlyArrayList
 * 
 * See SouceCode http://referencesource.microsoft.com/#mscorlib/system/collections/arraylist.cs#3e3f6715773d6643
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace CSharpDemo.Lang.Collection
{
    public class ArrayListDemo
    {
        public static void Demo()
        {
            ArrayList list = new ArrayList();
            for (int i = 0; i < 10; i++)
            {
                list.Add(new Object());
            }
        }

        /// <summary>
        /// ArrayList => SyncArrayList
        /// </summary>
        public static void TestSyncArrayList()
        {
            ArrayList listSrc = new ArrayList();
            Enumerable.Range(1, 10).ToList().ForEach((x) => { listSrc.Add(x); });

            ArrayList listSync = ArrayList.Synchronized(listSrc);
            Console.WriteLine("listSync.IsSynchronized" + listSync.IsSynchronized);
        }

        /// <summary>
        /// ArrayList => ReadOnlyList
        /// </summary>
        public static void TestReadOnlyArrayList()
        {
            ArrayList listSrc = new ArrayList();
            Enumerable.Range(1, 10).ToList().ForEach((x) => { listSrc.Add(x); });

            ArrayList listReadOnly = ArrayList.ReadOnly(listSrc);
            Console.WriteLine("listSync.IsReadOnly" + listReadOnly.IsReadOnly);
        }

    }
}
