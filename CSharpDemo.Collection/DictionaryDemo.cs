using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpDemo.Lang.Collection
{
    public class DictionaryDemo
    {
        public static void Test()
        {
            Dictionary<String, int> dict = new Dictionary<string, int>();
            dict.Add("key1", 1);
            dict.Add("key1", 2);
        }
    }
}
