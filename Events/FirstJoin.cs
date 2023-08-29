using SteveSharp;
using SteveSharp.Core;

namespace RetoHardcore.Events
{
    public static class FirstJoin
    {
        static Function firstJoin = new Function(FileOrganizer.GetFunctionPath("reto:events/first_join"));

        public static void Create(){
            string[] commands = {
               RT.sed.Set(20,"@s[tag=!rt.firstJoin]"),
               Entity.AddTag(Entity.Self(),"rt.firstJoin") 
            };
            firstJoin.WriteAllCommands(commands);
        }
    }
}