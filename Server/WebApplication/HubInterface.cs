using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication
{
	public interface HubInterface
	{
		Task BrodcastMessage(string name, string message);
	}
}
