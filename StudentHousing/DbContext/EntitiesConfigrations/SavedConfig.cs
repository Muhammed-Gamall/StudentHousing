namespace StudentHousing.DbContext.EntitiesConfigrations
{
    public class SavedConfig : IEntityTypeConfiguration<Saved>
    {
        public void Configure(EntityTypeBuilder<Saved> builder)
        {
            builder.HasKey(s => new { s.SavedStudentId, s.SavedHouseId });

        }
    }
}
