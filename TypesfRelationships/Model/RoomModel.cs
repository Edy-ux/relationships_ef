using System.Text.Json.Serialization;

namespace TypesfRelationships.Model
{
    public class RoomModel
    {
        public int Id { get; set; }
        public string Description { get; set; }

        public int HouseId { get; set; }
        [JsonIgnore]
        public HouseModel House { get; set; }

    }
}
