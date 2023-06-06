using movie.Data.Static;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using movie.ServicesContracts;
using movie.Data.ViewModels;


namespace movie.Controllers
{
	[Authorize(Roles = UserRoles.Admin)]
	public class ProducersController : Controller
	{
		private readonly IProducersService _service;

		public ProducersController(IProducersService service)
		{
			_service = service;
		}

		[AllowAnonymous]
		public async Task<IActionResult> Index()
		{
			var allProducers = await _service.GetAllAsync();
			return View(allProducers);
		}

		//GET: producers/details/1
		[AllowAnonymous]
		public async Task<IActionResult> Details(int id)
		{
			var producerDetails = await _service.GetByIdAsync(id);

			if (producerDetails == null) return View("NotFound");
			return View(producerDetails);
		}

		//GET: producers/create
		public IActionResult Create()
		{
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> Create(ProducerDTO producer)
		{
			if (!ModelState.IsValid) return View(producer);

			await _service.AddNewProducerAsync(producer);
			return RedirectToAction(nameof(Index));
		}

		//GET: producers/edit/1
		public async Task<IActionResult> Edit(int id)
		{
			var producerDetails = await _service.GetProducerByIdAsync(id);
			if (producerDetails == null) return View("NotFound");

            var response = new ProducerDTO()
            {
                Id = producerDetails.Id,
                FullName = producerDetails.FullName,
                Bio = producerDetails.Bio,
                ProfilePictureURL = producerDetails.ProfilePictureURL, 
            };
            return View(response);
		}

		[HttpPost]
		public async Task<IActionResult> Edit(int id, ProducerDTO producer)
        {
			if (id != producer.Id) return View("NotFound");

            if (!ModelState.IsValid) return View(producer);
            
			await _service.UpdateProducerAsync(producer);
			return RedirectToAction(nameof(Index));
		}

		//GET: producers/delete/1
		public async Task<IActionResult> Delete(int id)
		{
			var producerDetails = await _service.GetByIdAsync(id);
			if (producerDetails == null) return View("NotFound");
			return View(producerDetails);
		}

		[HttpPost, ActionName("Delete")]
		public async Task<IActionResult> DeleteConfirmed(int id)
		{
			var producerDetails = await _service.GetByIdAsync(id);
			if (producerDetails == null) return View("NotFound");

			await _service.DeleteAsync(id);
			return RedirectToAction(nameof(Index));
		}
	}
}

