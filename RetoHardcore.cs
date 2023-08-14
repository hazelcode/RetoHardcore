using SteveSharp;

namespace RetoHardcore {
	public class RetoHardcore {
		public static void Main(){
			Project p = new Project(
				name: "Reto Hardcore",
				description: "Reto Hardcore by Mikel & LezaH",
				id: "reto",
				pack_format: 15,
				load: "load",
				main: "main"
			);
			Console.ReadLine();
		}
	}
}