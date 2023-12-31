using SteveSharp;
using SteveSharp.Core;

namespace RetoHardcore.Events
{
    public static class Attack
    {
        static Function attack = new Function(FileOrganizer.GetFunctionPath("reto:events/attack"));
        public static void Create(){
            string[] commands = {
                Execute.Write(
                    Execute.As("@s[gamemode=survival,scores={rt.sed=1..}]") +
                    Execute.If("predicate reto:random/sed/attack"),
                    new string[]{
                        RT.sed.Remove(Entity.Self(),1)
                    }
                ),
                "advancement revoke @s only reto:player_attack_entity",
                "advancement revoke @s only reto:player_kill_entity"
            };
            attack.WriteAllCommands(commands);
        }
    }
}