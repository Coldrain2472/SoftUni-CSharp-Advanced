﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuple
{
    public class CustomTuple<T1, T2>
    {
        private T1 Item1 { get; set; }
        private T2 Item2 { get; set;}

        public CustomTuple(T1 item1, T2 item2)
        {
            Item1 = item1;
            Item2 = item2;
        }

        public override string ToString()
        {
            return $"{Item1} -> {Item2}";
        }
    }
}
