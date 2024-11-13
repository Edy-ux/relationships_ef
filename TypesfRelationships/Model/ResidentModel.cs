using System.Text.Json.Serialization;

namespace TypesfRelationships.Model
{
    public class ResidentModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = String.Empty;

        [JsonIgnore]
        public List<HouseModel> House { get; set; } = new();

    }
}
