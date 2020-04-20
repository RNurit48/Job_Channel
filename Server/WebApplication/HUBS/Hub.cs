using BO;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.ControlleService;

namespace WebApplication
{
	public class Hub : Hub<HubInterface>
	{
        private readonly HomeController _controllerService;

        public Hub(HomeController controllerService)
        {
            _controllerService = controllerService;
        }

        //On code les fonction que le client peut appeler sur le serveur
        //public async Task<List<Offre>> GetAllOffre()
        //{
        //    return await _controllerService.GetAllOffre();
        //}

    }

}

