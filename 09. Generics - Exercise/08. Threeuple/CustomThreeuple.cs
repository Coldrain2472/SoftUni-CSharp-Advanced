﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Threeuple
{
    public class CustomThreeuple<T1, T2, T3>
    {
        private T1 Item1 { get; set; }
        private T2 Item2 { get; set; }
        private T3 Item3 { get; set; }

        public CustomThreeuple(T1 item1, T2 item2, T3 item3)
        {
            Item1 = item1;
            Item2 = item2;
            Item3 = item3;
        }

        public override string ToString()
        {
            return $"{Item1} -> {Item2} -> {Item3}";
        }
    }
}