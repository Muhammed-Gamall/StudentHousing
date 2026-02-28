using System.ComponentModel.DataAnnotations.Schema;

namespace StudentHousing.Entities
{
    public class Saved
    {

        public int SavedStudentId { get; set; }
        public Student Student { get; set; } = default!;

        public int SavedHouseId { get; set; }
        public House House { get; set; } = default!;
    }
}
