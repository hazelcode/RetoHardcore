using SteveSharp;
using SteveSharp.Core;

namespace RetoHardcore.Events
{
    public static class DrinkWater
    {
        static Function drinkWater = new Function(FileOrganizer.GetFunctionPath("reto:events/drink_water"));

        public static void Create(){
            string[] commands = {
                "advancement revoke @s only reto:drink_water",
                RT.sed.Add(6,"@s[gamemode=survival]")
            };
            drinkWater.WriteAllCommands(commands);
        }
    }
}