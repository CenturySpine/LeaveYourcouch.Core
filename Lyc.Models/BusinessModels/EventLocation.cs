namespace Lyc.Models.BusinessModels
{
    public class EventLocation
    {
        public int Id { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }

        public string Lat { get; set; }
        public string Lng { get; set; }
    }
}
