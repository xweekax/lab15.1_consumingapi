using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;


namespace Lab15._1_ConsumingAnAPI.Models
{
    public class Cards
    {
        public bool success { get; set; }
        public string Deck_id { get; set; }
        public bool shuffled { get; set; }
        public int remaining { get; set; }

    }




}
