using SteveSharp;
using SteveSharp.Core;
using RetoHardcore.Events;
namespace RetoHardcore
{
    public class Main
    {
        public void Create() {
            Function main = new Function(FileOrganizer.GetFunctionPath("reto:main"));
            string[] contents = {
                "## CORAZÓN FRÍO",
                Execute.Write(
                    Execute.Asat("@a[scores={rt.corazonFrio=1..,rt.corazonFrio.Cooldown=0},predicate=reto:item/corazon_frio]"),
                    new[]{ main.Call("reto:item/corazon_frio") }
                ),
                Execute.Write(
                    Execute.As("@a[scores={rt.corazonFrio.Cooldown=1..6000}]"),
                    new[]{ RT.corazonFrioCooldown.Remove(Entity.Closest(),1) }
                ),
                Execute.Write(
                    Execute.As("@a[scores={rt.corazonFrio.Cooldown=..0}]"),
                    new[]{ RT.corazonFrioCooldown.Set(0, Entity.Self()) }
                ),
                RT.corazonFrio.Reset("@a[scores={rt.corazonFrio=1..}]"),
                "\n## SED",
                Execute.Write(
                    Execute.As("@a[scores={rt.sed=21..}]"),
                    new[]{ RT.sed.Set(20, Entity.Self()) }
                ),
                Execute.Write(
                    Execute.As(Entity.Everyone("gamemode=!creative,gamemode=!spectator")),
                    new[]{ main.Call("reto:sed_display") }
                ),
                Execute.Write(
                    Execute.As(Entity.Everyone("predicate=reto:statements/sprinting,gamemode=survival,scores={rt.sed=1..}")) +
                    Execute.If("predicate reto:random/sed/sprinting"),
                    new[]{ RT.sed.Remove(Entity.Self(), 1) }
                ),
                Execute.Write(
                    Execute.As(Entity.Everyone("gamemode=survival,scores={rt.sed=1..}")) +
                    Execute.If("predicate reto:time/day") +
                    Execute.If("predicate reto:random/sed/sun"),
                    new[]{ RT.sed.Remove(Entity.Self(), 1) }
                ),
                "",
                Execute.Write(
                    Execute.As(Entity.Everyone("scores={rt.sed=..12}")),
                    new[]{ "effect give @s slowness 5 0 true" }
                ),
                Execute.Write(
                    Execute.As(Entity.Everyone("scores={rt.sed=..10}")),
                    new[]{ "effect give @s slowness 5 1 true" }
                ),
                Execute.Write(
                    Execute.As(Entity.Everyone("scores={rt.sed=..8}")),
                    new[]{
                        "effect give @s nausea 5 0 true",
                        "effect give @s slowness 5 2 true",
                        "effect give @s mining_fatigue 5 0 true"
                    }
                ),
                Execute.Write(
                    Execute.As(Entity.Everyone("scores={rt.sed=..4}")),
                    new[]{
                        "effect give @s slowness 5 3 true",
                        "effect give @s weakness 5 0 true",
                        "effect give @s mining_fatigue 5 1 true"
                    }
                ),
                Execute.Write(
                    Execute.As(Entity.Everyone("scores={rt.sed=0}")),
                    new[]{ RT.sedHurtInterval.Add(1, Entity.Self()) }
                ),
                Execute.Write(
                    Execute.As(Entity.Everyone("scores={rt.sed=0,rt.sed.hurtInterval=40..}")),
                    new[]{
                        "damage @s 2 dry_out",
                        RT.sedHurtInterval.Reset(Entity.Self())
                    }
                ),
                "",
                Execute.Write(
                    Execute.As(Entity.Everyone("scores={rt.dieEvent=1}")),
                    new[]{ RT.sed.Set(20, Entity.Self())}
                ),
                "\n## RESETEAR MUERTES",
                Execute.Write(
                    Execute.As(Entity.Everyone("scores={rt.dieEvent=1..}")),
                    new[]{
                        RT.dieEvent.Reset(Entity.Self())
                    }
                ),
                Execute.Write(
                    Execute.Asat(Entity.Everyone(),
                    Execute.If("block ~ ~-1 ~ bedrock ")
                    ),
                    new string[] { "effect give @p levitation 10 20 true" }
                ),
                "\n##EVENTOS",
                main.Extend("reto:events/death_screen/death", DeathScreen.deathDetectCommands, true),
                main.Extend("reto:events/death_screen/death_screen", DeathScreen.deathScreenCommands, true)
            };
            main.WriteAllCommands(contents);
        }
    }
}