using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using InfiniteList;

namespace InfiniteList
{
    class Program
    {
        static void Main(string[] args)
        {
            var il = new ILEnumerator();

            for (int i = 0; i < 989898; ++i)
            {
                il.MoveNext();
                Console.WriteLine($"current == {il.Current}");
            }
            var iss = new IL();

            foreach (int i in iss)
            {
                Console.WriteLine(i);
            }
           
        }
    }
}
