using eTickets.Models;

namespace eTickets.Data.Services
{
    public interface IProducersService
    {
        Task<IEnumerable<Producer>> GetAllAsync();
        Task<Producer> GetByIdAsync(int id);
        Task AddAsync(Producer producer);    
        Task<Producer> UpdateAsync(int id, Producer newProducer);
        Task DeleteAsync(int id);
    }
}
