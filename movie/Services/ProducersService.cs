using Microsoft.EntityFrameworkCore;
using movie.Data;
using movie.Data.Base;
using movie.Data.ViewModels;
using movie.Models;
using movie.ServicesContracts;

namespace movie.Services
{
    public class ProducersService : EntityBaseRepository<Producer>, IProducersService
    {
        private readonly AppDbContext _context;
        public ProducersService(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task AddNewProducerAsync(ProducerDTO data)
        {
            var newProducer = new Producer()
            {
                FullName = data.FullName,
                ProfilePictureURL = data.ProfilePictureURL,
                Bio = data.Bio
            };
            await _context.Producers.AddAsync(newProducer);
            await _context.SaveChangesAsync();

        }
        public async Task UpdateProducerAsync(ProducerDTO data)
        {
            var dbProducer = await _context.Producers.FirstOrDefaultAsync(n => n.Id == data.Id);
            if (dbProducer != null)
            {
                dbProducer.FullName=data.FullName;
                dbProducer.Bio=data.Bio;
                dbProducer.ProfilePictureURL=data.ProfilePictureURL;
                await _context.SaveChangesAsync();
            }
            
        }

        public async Task<Producer> GetProducerByIdAsync(int id)
        {
            var producerDetails = await _context.Producers
                 .FirstOrDefaultAsync(n => n.Id == id);
            return producerDetails;
        }

        public async Task DeleteProducerAsync(ProducerDTO data)
        {
            var dbProducer = await _context.Producers.FirstOrDefaultAsync(n => n.Id == data.Id);
            if (dbProducer != null)
            {
                _context.Producers.Remove(dbProducer);
                await _context.SaveChangesAsync();
            }
            }

        Task IProducersService.DeleteCinemaAsync(NewCinemaVM data)
        {
            throw new NotImplementedException();
        }
    }
}
