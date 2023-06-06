
using movie.Data.Base;
using movie.Data.ViewModels;
using movie.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace movie.ServicesContracts
{
    public interface IProducersService : IEntityBaseRepository<Producer>
    {
        Task<Producer> GetProducerByIdAsync(int id);
        Task AddNewProducerAsync(ProducerDTO data);
        Task UpdateProducerAsync(ProducerDTO data);
        Task DeleteCinemaAsync(NewCinemaVM data);
    }
}
