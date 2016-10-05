using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VinySamling
{
    class VinylList
    {
        public string[] name;

        public VinylList(string[] name)
        {
            Name = name;
        }
        public string[] Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}
