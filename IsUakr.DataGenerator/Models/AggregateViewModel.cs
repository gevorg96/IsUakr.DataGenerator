using System.Collections.Generic;
using IsUakr.DAL.Entities;

namespace IsUakr.DataGenerator.Models
{
    public class AggregateViewModel
    {
        public List<Street> Streets { get; set; }
        public MeterHub Hub { get; set; }
        public List<Meter> Meters { get; set; }
        public List<Flat> Flats { get; set; }
    }
}