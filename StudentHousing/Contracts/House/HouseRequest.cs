namespace StudentHousing.Contracts.House
{
    public record HouseRequest
   (
    string Description ,
    string Location ,
    int Rooms ,
    int Beds ,
    int Floor ,
    int Phone,
    int Price ,
    string Sex ,
    int OwnerId
   );
    
}
