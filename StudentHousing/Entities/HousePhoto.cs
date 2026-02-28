namespace StudentHousing.Entities
{
    public class HousePhoto
    {

        public int Id { get; set; }
        public byte[]? Photo { get; set; }
        public int HouseId { get; set; } 
        public  House house { get; set; } = default!;   
    }
}
