using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab15._1_ConsumingAnAPI.Models
{
    public class TheDraw
    {
        public bool success { get; set; }
        public string Deck_id { get; set; }
        public TheCards[] cards { get; set; }
    }
}
