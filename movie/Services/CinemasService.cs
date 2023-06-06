
using Microsoft.EntityFrameworkCore;
using movie.Data;
using movie.Data.Base;
using movie.Data.Services;
using movie.Data.ViewModels;
using movie.Models;
using movie.ServicesContracts;



namespace movie.Services
{
    public class CinemasService : EntityBaseRepository<Cinema>, ICinemasService
    {
        private readonly AppDbContext _context;
        public CinemasService(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task AddNewCinemaAsync(NewCinemaVM data)
        {
            var newCinema = new Cinema()
            {

                Logo = data.Logo,
                Name = data.Name,
                Description = data.Description,


            };
            await _context.Cinemas.AddAsync(newCinema);
            await _context.SaveChangesAsync();

        }

        public async Task UpdateCinemaAsync(NewCinemaVM data)
        {
            var dbCinema = await _context.Cinemas.FirstOrDefaultAsync(n => n.Id == data.Id);
            if (dbCinema != null)
            {

                dbCinema.Logo = data.Logo;
                dbCinema.Name = data.Name;
                dbCinema.Description = data.Description;
                await _context.SaveChangesAsync();
            }
            await _context.SaveChangesAsync();



        }
        

        public async Task DeleteCinemaAsync(NewCinemaVM data)
        {
            var dbCinema = await _context.Cinemas.FirstOrDefaultAsync(n => n.Id == data.Id);
            if (dbCinema != null)
            {
                _context.Cinemas.Remove(dbCinema);
                await _context.SaveChangesAsync();
            }
        }
    }
}