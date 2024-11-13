using System.Text.Json.Serialization;

namespace TypesfRelationships.Model
{
    public class AddressModel
    {
        public int Id { get; set; }
        public string Street { get; set; } = String.Empty;
        public int Number { get; set; } 
        public int HouseId { get; set; }

        [JsonIgnore]
        public HouseModel House { get; set; }
        
        public string? City { get; set; } = String.Empty;
        public string? State { get; set; }  = String.Empty;
    }
}