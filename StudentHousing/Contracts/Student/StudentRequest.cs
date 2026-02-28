namespace StudentHousing.Contracts.Student
{
    public record StudentRequest
     (
     string FirstName,
  string LasttName,
   string Sex,
   int Level,
   string Faculty,
   string City,
    byte[]? Photo
    );
}
