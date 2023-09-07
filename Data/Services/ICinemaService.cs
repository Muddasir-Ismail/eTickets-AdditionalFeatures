using eTickets.Data.Base;
using eTickets.Models;

namespace eTickets.Data.Services
{
    public interface ICinemaService
    {
        Task<IEnumerable<Cinema>> GetAllAsync();
        Task<Cinema> GetByIdAsync(int id);
        void Cinema(Cinema cinema);
        Task<Cinema> UpdateAsync(int id,Cinema newCinema);
        Task DeleteAsync(int id);
        Task AddAsync(Cinema cinema);
    }
}
