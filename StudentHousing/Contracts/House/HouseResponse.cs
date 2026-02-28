namespace StudentHousing.Contracts.House
{
    public record HouseResponse
    (
        int Id,
    string Description,
    string Location,
    int Rooms,
    int Beds,
    int Floor,
    int Phone,
    int Price,
    string Sex,
    int OwnerId
   );
}
