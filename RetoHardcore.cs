using SteveSharp;
using SteveSharp.Core;

namespace RetoHardcore {
	public class RetoHardcore {
		public static void Main(){
			FileOrganizer FO = new FileOrganizer();
			RT rt = new RT();
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

			Main Main = new Main();
			Main.Create();
			SedDisplay SedDisplay = new SedDisplay();
			SedDisplay.Create();

			Console.ReadLine();
		}
	}
}