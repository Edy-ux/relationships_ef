
namespace TypesfRelationships.Dtos
{
    public class CreateHouseDTO
    {
        public string Description { get; set; }

        public CreateAddressDTO Address { get; set; }

        public List<CreateRoomDTO> Rooms { get; set; } = new();

        public List<CreateResidentDTO> Residents { get; set; } = new();



    }


}
