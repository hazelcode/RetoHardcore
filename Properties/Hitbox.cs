using SteveSharp;
using SteveSharp.Core;

namespace RetoHardcore.Properties
{
    public static class Hitbox
    {
        static Function hitbox = new Function(FileOrganizer.GetFunctionPath("reto:properties/hitbox"));
        
        public static void Create(){
            string[] commands = {
                Entity.Teleport(Entity.Self(),Entity.AllEntities("tag=rt.hitbox.target,limit=1")),
                Execute.Write(
                    Execute.As(Entity.Self(),
                    "on attacker "
                    ),
                    new string[]{
                        "damage " + Entity.AllEntities("distance=..2,limit=1,tag=rt.hitbox.target") + " 1 generic_kill"
                    }
                )
            };
            hitbox.WriteAllCommands(commands);
        }
    }
}