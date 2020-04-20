using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL;
using BO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Logging;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication.ControlleService
{
    public class HomeController : ControllerBase
    {
        // GET: /<controller>/

        [ApiController] // API REST
        [Route("/api/[controller]")] // /api/library
        public class LibraryController : ControllerBase
        {
            private readonly ILogger<LibraryController> _logger;
            private readonly IController _controllerService;
            private readonly IHubContext<Hub, HubInterface> _hubContext;

            public LibraryController(ILogger<LibraryController> logger, IController controllerService, IHubContext<Hub, HubInterface> hubContext)
            {
                // Récupération des service avec l'IOC (injections de dépendances)
                _logger = logger;
                _controllerService = controllerService;
                _hubContext = hubContext;
            }

            //public  Task<List<Offre>> GetAllOffre()
            //{
            //    return _controllerService.GetOffres();
            //}
        }
    }
}
