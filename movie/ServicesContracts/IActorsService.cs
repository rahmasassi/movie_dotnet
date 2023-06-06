using movie.Data.Base;
using movie.Data.ViewModels;
using movie.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace movie.ServicesContracts
{
    public interface IActorsService : IEntityBaseRepository<Actor>
    {

        Task<Actor> GetActorByIdAsync(int id);

        Task UpdateActorAsync(ActorDTO data);


        Task AddNewActorAsync(ActorDTO data);
    }
}
