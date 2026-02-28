using System.ComponentModel.DataAnnotations.Schema;

namespace StudentHousing.Entities
{
    public class House
    {
        public int Id { get; set; }
        public required string Description { get; set; }
        public required string Location { get; set; }
        public required int Rooms { get; set; }
        public required int Beds { get; set; }
        public required int Floor { get; set; }
        public required int Phone { get; set; }
        public required int Price { get; set; }
        public required string Sex { get; set; }
        public DateTime CreatedOn { get; set; } = DateTime.UtcNow;
        public int OwnerId { get; set; }
        public required Owner Owner { get; set; }
        public List<HousePhoto> HousePhoto { get; set; } = [];
        public List<Roommate> Roommate { get; set; } = [];
    }
}
