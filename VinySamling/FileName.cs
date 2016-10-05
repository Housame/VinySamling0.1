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

       
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string[] vinylList;
        public string[] VinylList
        {
            get { return vinylList; }
            set { vinylList = value; }
        }

        public string filePathString;
        public string FilePathString
        {
            get { return filePathString; }
            set { filePathString = value; }
        }
    }
}
