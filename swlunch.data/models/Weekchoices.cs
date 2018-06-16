using System;
using System.Collections.Generic;

namespace swlunch.mvc
{
    public partial class Weekchoices
    {
        public int Id { get; set; }
        public int Usernum { get; set; }
        public int Choicenum { get; set; }
        public DateTime Choiceweek { get; set; }
    }
}
