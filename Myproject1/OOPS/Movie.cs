using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject1.OOPS
{
    class Movie
    {
        string moviename;
        int rating;
        


        public string Moviename
        {
            set { moviename = value; }
            get { return moviename; }
        }

        public int Rating
        {
            set { rating = value; }
            get { return rating; }
        }

        
    }
}
