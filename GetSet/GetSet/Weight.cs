using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetSet
{
	class Weight
	{

		int yourWeight;

		public int YourWeight
		{
			get { return yourWeight; }
			set
			{
				if (value > 0)
				{
					yourWeight = value;
					Console.WriteLine("WOW YOU ARE FAT!!!");
				}
				else
					yourWeight = 0;
			}
		}

	}
}
