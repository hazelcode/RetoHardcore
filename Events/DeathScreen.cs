using SteveSharp;
using SteveSharp.Core;
using SteveSharp.JsonShapes;
using System.Text.Json;

namespace RetoHardcore.Events
{
    public static class DeathScreen
    {
        public static string[] deathDetectCommands = {
            "gamemode spectator @a[scores={reto.Muerto=1..}]",
            RT.deathScreen.Set(1,Entity.Everyone("scores={reto.Muerto=1}"))
        };
        public static string[] deathScreenCommands = {
            Execute.Write(
                Execute.If("score @a[limit=1] reto.DeathScreen matches 1"),
                new string[] {
                    "title @a title " + new string(JsonSerializer.Serialize(
                        Text.New("RT", "red")
                    )),
                    "title @a subtitle " + new string(JsonSerializer.Serialize(
                        Text.New("¡Alguien ha muerto!", "gold")
                    )),
                    RT.dieEvent.Reset(Entity.Everyone()),
                    RT.deathScreen.Reset(Entity.Everyone()),
                    "playsound minecraft:entity.blaze.death master @a ~ ~ ~ 1 0.6"
                }
            )
        };
    }
}