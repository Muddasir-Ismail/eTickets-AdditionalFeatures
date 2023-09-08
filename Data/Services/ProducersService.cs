using eTickets.Models;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Data.Services
{
    public class ProducersService : IProducersService
    {
        private readonly AppDbContext _context;
        public ProducersService(AppDbContext context)
        {
            _context = context;
        }
        public async Task AddAsync(Producer producer)
        {
            await _context.Producers.AddAsync(producer);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var result = await _context.Producers.FirstOrDefaultAsync(n => n.Id == id);
            _context.Producers.Remove(result);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Producer>> GetAllAsync()
        {
            var results = await _context.Producers.ToListAsync();
            return results;
        }

        public async Task<Producer> GetByIdAsync(int id)
        {
            var result = await _context.Producers.FirstOrDefaultAsync(n => n.Id == id);
            return result;
        }

        public async Task<Producer> UpdateAsync(int id, Producer newProducer)
        {
            _context.Update(newProducer);
            await _context.SaveChangesAsync();
            return newProducer;
        }
    }
}
