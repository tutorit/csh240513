using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syntax
{
    internal class Pair<T,S>
    {
        T first;
        S second;

        public Pair(T first, S second)
        {
            this.first= first;
            this.second= second;
        }

        public override string ToString()
        {
            return "("+first+", "+second+")";   
        }
    }
}
