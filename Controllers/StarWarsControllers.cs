using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace API.Controllers
{
    public class StarWarsControllers : Controller
    {
        private readonly ILogger<StarWarsControllers> _logger;
        private readonly FinalSpaceClient _finalSpaceClient;

        public StarWarsControllers(ILogger<StarWarsControllers> logger, FinalSpaceClient finalSpaceClient)
        {
            _logger = logger;
            _finalSpaceClient = finalSpaceClient;
        }
        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> Person()
        {
            var response = await _finalSpaceClient.Peoples();

            var viewModel = new PeopleViewModel();
            viewModel.Peoples = response
                .Select(response => new PeopleVM() { name = response.name, url = response.url })
                .ToList();


            return View(viewModel);
        }

        public async Task<IActionResult> Planet()
        {
            var response = await _finalSpaceClient.Planets();

            var viewModel = new PlanetViewModel();
            viewModel.Planets = response
                .Select(response => new PlanetVM() { name = response.name, url = response.url })
                .ToList();


            return View(viewModel);
        }

    }
}
