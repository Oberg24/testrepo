using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp {
	class Program {
		static void Main(string[] args) {
			System.Diagnostics.Debug.Print("test");
			System.Diagnostics.Debug.Print("test git");
			System.Diagnostics.Debug.Print("change more");
			PrintMoreStuff();
			PrintPerson();
		}

		private static void PrintMoreStuff() {
			System.Diagnostics.Debug.Print("Made in Johan Branch");
		}

		private static void PrintPerson() {
			var p = new Person();
			System.Diagnostics.Debug.Print(string.Format("{0}, {1}", p.Name, p.Adress));
		}

	}
}
