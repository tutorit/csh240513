using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syntax
{
    internal struct Vector
    {
        public int i { get; set; }
        public int j { get; set; }

        public Vector(int i=0,int j=0)
        {
            this.i=i; 
            this.j=j;
        }
    }
}
