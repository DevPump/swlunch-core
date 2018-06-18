using System;
using System.Collections.Generic;

namespace swlunch.data.models
{
    public partial class Lunchchoices
    {
        public int Id { get; set; }
        public int Userid { get; set; }
        public int Userchoice { get; set; }
        public DateTime Weekdate { get; set; }
        public bool Dictatorchoice { get; set; }
    }
}
