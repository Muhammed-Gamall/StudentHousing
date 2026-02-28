using System.ComponentModel.DataAnnotations;

namespace StudentHousing.Entities
{
    public class Roommate
    {
        [Key]
        public int StudentId { get; set; }
        public  Student Student { get; set; }= default!;

        public int HouseIdForRoommate { get; set; }
        public  House House { get; set; } = default!;
    }
}
