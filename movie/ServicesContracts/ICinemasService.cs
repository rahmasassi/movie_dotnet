using movie.Data.Base;
using movie.Data.ViewModels;
using movie.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace movie.Data.Services
{
    public interface ICinemasService : IEntityBaseRepository<Cinema>
    {

        Task AddNewCinemaAsync(NewCinemaVM data);
        Task UpdateCinemaAsync(NewCinemaVM data);
        Task DeleteCinemaAsync(NewCinemaVM data);


    }
}