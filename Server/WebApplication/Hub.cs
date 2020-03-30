using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication
{
	public class Hub : Hub<HubInterface>
	{
		public void Test(string name, string message)
		
		{
			Clients.All.BrodcastMessage(name, message);
		}


	}
}
