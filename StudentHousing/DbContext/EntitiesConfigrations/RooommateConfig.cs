

namespace StudentHousing.DbContext.EntitiesConfigrations
{
    public class RooommateConfig : IEntityTypeConfiguration<Roommate>
    {
        public void Configure(EntityTypeBuilder<Roommate> builder)
        {
            builder.HasOne(r => r.Student)
                .WithOne(s => s.Roommate)
                .HasForeignKey<Roommate>(r => r.StudentId);
            builder.HasOne(r => r.House)
                .WithMany(h => h.Roommate)
                .HasForeignKey(r => r.HouseIdForRoommate);
        }
    }
}
