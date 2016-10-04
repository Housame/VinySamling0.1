using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VinySamling
{
    class Vinyl
    {
        static string name;
        public static string Name
        {
            get { return name; }
            set { name = value; }
        }

        static string album;
        public static string Album
        {
            get { return album; }
            set
            { album = value; }
        }


        static string artist;
        public static string Artist
        {
            get { return artist; }
            set { artist = value; }
        }

        static int year;
        public static int Year
        {
            get { return year; }
            set { year = value; }
        }

       
    }

}
