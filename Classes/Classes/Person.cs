using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
	class Person
	{
		string name;
		int age;

		void CelebrateBirthDay()
		{
			age++;
		}

		void ChangeName()
		{
			name = "Olf Dolf";
		}
	}
}
