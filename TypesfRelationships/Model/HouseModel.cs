
namespace TypesfRelationships.Model
{
    public class HouseModel
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public AddressModel Address { get; set; }
        public List<RoomModel> Rooms { get; set; } = new();
        public List<ResidentModel> Residents { get; set; } = new();

    }
}
