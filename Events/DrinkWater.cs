using SteveSharp;
using SteveSharp.Core;

namespace RetoHardcore.Events
{
    public static class DrinkWater
    {
        static FileOrganizer FO = new FileOrganizer();
        static Execute Execute = new Execute();
        static Entity Entity = new Entity();
        static XYZ XYZ = new XYZ();
        static Function drinkWater = new Function(FO.GetFunctionPath("reto:events/drink_water"));

        public static void Create(){
            string[] commands = {
                "advancement revoke @s only reto:drink_water",
                RT.sed.Add(6,"@s[gamemode=survival]")
            };
            drinkWater.WriteAllCommands(commands);
        }
    }
}