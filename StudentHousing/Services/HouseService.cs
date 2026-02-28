using StudentHousing.Contracts.House;

namespace StudentHousing.Services
{
    public class HouseService(ApplicationDbContext context) : IHouseService
    {
        private readonly ApplicationDbContext _context = context;
        public async Task<IEnumerable<HouseResponse>> GetAllHouses(CancellationToken cancellation = default)
        {
           var houses = await _context.Houses.AsNoTracking().ToListAsync(cancellation);
            var response = houses.Adapt<IEnumerable<HouseResponse>>();
            return response;
        }

        public async Task<HouseResponse?> GetHouseById(int id, CancellationToken cancellation = default)
        {
            var house = await _context.Houses.AsNoTracking().FirstOrDefaultAsync(x=>x.Id== id);
            var response = house.Adapt<HouseResponse>();
            return response;
        }

        public async Task<HouseResponse> CreateHouse(HouseRequest request, CancellationToken cancellation = default)
        {
           var house = request.Adapt<House>();
            await _context.Houses.AddAsync(house, cancellation);
            await _context.SaveChangesAsync(cancellation);
            var response = house.Adapt<HouseResponse>();
            return response;
        }

        public async Task<bool> UpdateHouse(HouseRequest request, int id, CancellationToken cancellation = default)
        {
            var isExist = await GetHouseById(id);
            if (isExist == null)
                return false;

            var house = request.Adapt(isExist);
            var entity = house.Adapt<House>(); 

            _context.Houses.Update(entity);
            await _context.SaveChangesAsync(cancellation);
            return true;
        }

        public async Task<bool> DeleteHouse(int id, CancellationToken cancellation = default)
        {
            var isExist = await GetHouseById(id);
            if (isExist == null)
                return false;

            var entity = isExist.Adapt<House>();
            _context.Houses.Remove(entity);
            await _context.SaveChangesAsync(cancellation);
            return true;
        }

    }
}
