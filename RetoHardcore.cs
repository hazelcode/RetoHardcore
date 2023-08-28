using SteveSharp;
using SteveSharp.Core;
using RetoHardcore.Items;
using RetoHardcore.Events;
using RetoHardcore.Properties;

namespace RetoHardcore {
	public class RetoHardcore {
		public static void Main(){
			FileOrganizer FO = new FileOrganizer();
			Project p = new Project(
				name: "Reto Hardcore",
				description: "Reto Hardcore by Mikel & LezaH",
				id: "reto",
				pack_format: 15,
				load: "load",
				main: "main"
			);
			Function Load = new Function(FO.GetFunctionPath("reto:load"));
			static string AddObjectives(Score[] scores)
        	{
            	string commands = "";
            	foreach(Score score in scores)
            	{
                	commands += $"scoreboard objectives add {score.id} {score.type} {score.name}\n";
            	}
            	return commands;
        	}
			string[] commands = {
				AddObjectives(new Score[]{
					new Score("rt.return"),
            		new Score("rt.corazonFrio", "used:warped_fungus_on_a_stick"),
        	    	new Score("rt.corazonFrio.Cooldown"),
            		new Score("rt.sed"),
            		new Score("rt.sed.hurtInterval"),
	            	new Score("rt.dieEvent", "deathCount")
				})
			};
			Load.WriteAllCommands(commands);
			Main Main = new Main();
			Main.Create();
			SedDisplay.Create();
			ColdHeart.Create();
			Hitbox.Create();
			FirstJoin.Create();
			Attack.Create();
			DrinkWater.Create();
			Console.ReadLine();
		}
	}
}