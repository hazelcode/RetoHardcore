using SteveSharp;
using SteveSharp.Core;

namespace RetoHardcore.Properties
{
    public static class Hitbox
    {
        static FileOrganizer FO = new FileOrganizer();
        static Execute Execute = new Execute();
        static Entity Entity = new Entity();
        static Function hitbox = new Function(FO.GetFunctionPath("reto:properties/hitbox"));
        
        public static void Create(){
            string[] commands = {
                Entity.Teleport(Entity.Self,"@e[tag=rt.hitbox.target,limit=1]"),
                Execute.Write(
                    Execute.As(Entity.Self,
                    "on attacker "
                    ),
                    new string[]{
                        "damage @e[distance=..2,limit=1,tag=rt.hitbox.target] 1 generic_kill"
                    }
                )
            };
            hitbox.WriteAllCommands(commands);
        }
    }
}