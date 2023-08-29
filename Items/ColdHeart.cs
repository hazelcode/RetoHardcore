using SteveSharp;
using SteveSharp.Core;

namespace RetoHardcore.Items
{
    public static class ColdHeart
    {
        static Function coldHeart = new Function(FileOrganizer.GetFunctionPath("reto:item/corazon_frio"));

        public static void Create(){
            string[] commands = {
                "playsound block.glass.break master @a ~ ~ ~",
                "weather thunder",
                Entity.Summon(
                    "stray",
                    XYZ.Set("~17", "~1", "~-18")
                ),
                Entity.Summon(
                    "stray",
                    XYZ.Set("~-19", "~1", "~18")
                ),
                Entity.Summon(
                    "stray",
                    XYZ.Set("~15", "~1", "~14")
                ),
                Entity.Summon(
                    "stray",
                    XYZ.Set("~-13", "~1", "~19")
                ),
                Entity.Kill("@e[type=#reto:warm,distance=..20]"),
                "clear @s warped_fungus_on_a_stick{CustomModelData:1650001} 1",
                RT.corazonFrioCooldown.Set(6000, Entity.Self())
            };
            coldHeart.WriteAllCommands(commands);
        }
    }
}