namespace StudentHousing.Entities
{
    public class Owner
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public List<House>? Houses { get; set; } = [];
    }
}
