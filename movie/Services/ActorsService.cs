
using Microsoft.EntityFrameworkCore;
using movie.Data;
using movie.Data.Base;
using movie.Data.ViewModels;
using movie.Models;
using movie.ServicesContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace movie.Services
{
    public class ActorsService : EntityBaseRepository<Actor>, IActorsService
    {

        private readonly AppDbContext _context;

        public ActorsService(AppDbContext context) : base(context) {

            _context = context;
        }


        public async Task<Actor> GetActorByIdAsync(int id)
        {
            var actorDetails = await _context.Actors
                
               
                .FirstOrDefaultAsync(n => n.Id == id);

            return actorDetails;
        }


        public async Task AddNewActorAsync(ActorDTO data)
        {
            var newActor = new Actor()
            {
                FullName   = data.FullName,
                Bio = data.Bio,
                ProfilePictureURL = data.ProfilePictureURL,
              
            };
            await _context.Actors.AddAsync(newActor);
            await _context.SaveChangesAsync();
                      
        }








        public async Task UpdateActorAsync(ActorDTO data)
        {
            var dbActor = await _context.Actors.FirstOrDefaultAsync(n => n.Id == data.Id);

            if (dbActor != null)
            {
                dbActor.FullName = data.FullName;
                dbActor.Bio = data.Bio;
                dbActor.ProfilePictureURL = data.ProfilePictureURL;
                await _context.SaveChangesAsync();
            }

            
        }

    }
}
