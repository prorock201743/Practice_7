using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_7
{
    class Pair
    {
        public int First { get;  set; }
        public int Second { get;  set; }

        public Pair(int first, int second)
        {
            First = first;
            Second = second;
        }

        public static bool operator true(Pair pair) => pair.First == pair.Second ? true : false;

        public static bool operator false(Pair pair) => pair.First != pair.Second ? false : true;

        public Pair Substract(Pair subtrahend) => new Pair(First - subtrahend.First, Second - subtrahend.Second);
    }
}
