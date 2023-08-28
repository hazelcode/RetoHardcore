using SteveSharp;
using SteveSharp.Core;

namespace RetoHardcore.Events
{
    public static class FirstJoin
    {
        static FileOrganizer FO = new FileOrganizer();
        static Execute Execute = new Execute();
        static Entity Entity = new Entity();
        static XYZ XYZ = new XYZ();
        static Function firstJoin = new Function(FO.GetFunctionPath("reto:events/first_join"));

        public static void Create(){
            string[] commands = {
               RT.sed.Set(20,"@s[tag=!rt.firstJoin]"),
               Entity.AddTag(Entity.Self,"rt.firstJoin") 
            };
            firstJoin.WriteAllCommands(commands);
        }
    }
}