using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VinySamling
{
    class FileName
    {
        public string name;

        public FileName (string name)
        {
            Name = name;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}
