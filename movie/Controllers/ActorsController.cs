using movie.Data.Static;
using movie.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using movie.ServicesContracts;
using Microsoft.AspNetCore.Mvc.Rendering;
using movie.Data.ViewModels;

namespace movie.Controllers
{
	[Authorize(Roles = UserRoles.Admin)]
	public class ActorsController : Controller
	{
		private readonly IActorsService _service;

		public ActorsController(IActorsService service)
		{
			_service = service;
		}

		[AllowAnonymous]
		public async Task<IActionResult> Index()
		{
			var data = await _service.GetAllAsync();
			return View(data);
		}

		//Get: Actors/Create
		public IActionResult Create()
		{
			return View();
		}


        [HttpPost]
        public async Task<IActionResult> Create(ActorDTO actor)
        {
            if (!ModelState.IsValid) return View(actor);
            
            await _service.AddNewActorAsync(actor);
            return RedirectToAction(nameof(Index));
        }

        //Get: Actors/Details/1
        [AllowAnonymous]
		public async Task<IActionResult> Details(int id)
		{
			var actorDetails = await _service.GetByIdAsync(id);

			if (actorDetails == null) return View("NotFound");
			return View(actorDetails);
		}

        //Get: Actors/Edit/1
        public async Task<IActionResult> Edit(int id)
        {
            var actorDetails = await _service.GetActorByIdAsync(id);
            if (actorDetails == null) return View("NotFound");

            var response = new ActorDTO()
            {
                Id = actorDetails.Id,
                FullName = actorDetails.FullName,
                Bio = actorDetails.Bio,
                ProfilePictureURL = actorDetails.ProfilePictureURL,
            };
			   
            return View(response);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, ActorDTO actor)
        {
            if (id != actor.Id) return View("NotFound");

            if (!ModelState.IsValid) return View(actor);
            
            await _service.UpdateActorAsync(actor);
            return RedirectToAction(nameof(Index));
        }

        //Get: Actors/Delete/1
        public async Task<IActionResult> Delete(int id)
		{
			var actorDetails = await _service.GetByIdAsync(id);
			if (actorDetails == null) return View("NotFound");
			return View(actorDetails);
		}

		[HttpPost, ActionName("Delete")]
		public async Task<IActionResult> DeleteConfirmed(int id)
		{
			var actorDetails = await _service.GetByIdAsync(id);
			if (actorDetails == null) return View("NotFound");

			await _service.DeleteAsync(id);
			return RedirectToAction(nameof(Index));
		}
	}
}
