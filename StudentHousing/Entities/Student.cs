namespace StudentHousing.Entities
{
    public class Student
    {
        public int Id { set; get; }
        public required string FirstName { set; get; } = string.Empty;
        public required string LasttName { set; get; } = string.Empty;
        public required string Sex { get; set; }
        public required int Level { get; set; }
        public required string Faculty { get; set; }
        public required string City { get; set; }
        public byte[]? Photo { get; set; }
        public List<Saved> SavedHouses { get; set; } = [];
        public Roommate? Roommate { get; set; }
    }
}
