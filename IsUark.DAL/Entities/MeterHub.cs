using System.Collections.Generic;

namespace IsUakr.DAL.Entities
{
    public class MeterHub
    {
        public int id { get; set; }
        public House House { get; set; }
        public List<Meter> Meters { get; set; }
        public string code { get; set; }

    }
}