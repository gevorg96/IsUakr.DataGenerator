namespace IsUakr.DAL.Entities
{
    public class Meter
    {
        public int id { get; set; }
        public Flat Flat { get; set; }
        public MeterHub Hub { get; set; }
        public string code { get; set; }
        public string type { get; set; }
    }
}