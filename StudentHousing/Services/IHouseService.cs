using StudentHousing.Contracts.House;

namespace StudentHousing.Services
{
    public interface IHouseService
    {
        Task<IEnumerable<HouseResponse>> GetAllHouses( CancellationToken cancellation = default);
        Task<HouseResponse?> GetHouseById(int id, CancellationToken cancellation = default);
        Task<HouseResponse> CreateHouse(HouseRequest request, CancellationToken cancellation = default);
        Task<bool> UpdateHouse(HouseRequest request , int id , CancellationToken cancellation = default);
        Task<bool> DeleteHouse(int id, CancellationToken cancellation = default);
    }
}
