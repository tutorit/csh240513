using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syntax
{
    internal class Car
    {
        //private string make="Merkitön";
        private int speed = 10;

        public string Make { get; set; }

        public int Speed
        {
            get
            {
                return this.speed;
            }
            set
            {
                if (value<120) this.speed = value;
            }
        }
    }
}
