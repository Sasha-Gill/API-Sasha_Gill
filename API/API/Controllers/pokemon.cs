using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
	public class pokemon
	{
		public string Name
		{
			get
			{
				return Name;
			}
			set
			{
				Name = value.ToUpper();
			}
		}

		public int Strenght { get; set; }

	}
}
