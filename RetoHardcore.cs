using SteveSharp;
using SteveSharp.Core;

namespace RetoHardcore {
	public class RetoHardcore {
		public static void Main(){
			FileOrganizer FO = new FileOrganizer();
			rt rt = new rt();
			Project p = new Project(
				name: "Reto Hardcore",
				description: "Reto Hardcore by Mikel & LezaH",
				id: "reto",
				pack_format: 15,
				load: "load",
				main: "main"
			);
			Function Load = new Function(FO.GetFunctionPath("reto:load"));
			string[] loadContents = {
				rt.AddObjectives(rt.scores)
			};
			Load.WriteAllCommands(loadContents);
			Console.ReadLine();
		}
	}
}