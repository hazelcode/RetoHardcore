using SteveSharp.Core;

namespace RetoHardcore
{
    public class rt
    {
        public string AddObjectives(Score[] scores)
        {
            string commands = "";
            foreach(Score score in scores)
            {
                commands += $"scoreboard objectives add {score.id} {score.type} {score.name}\n";
            }
            return commands;
        }
        public static Score Return = new Score("rt.return");
        public static Score corazonFrio = new Score("rt.corazonFrio", "used:warped_fungus_on_a_stick");
        public static Score corazonFrioCooldown = new Score("rt.corazonFrio.Cooldown");
        public static Score sed = new Score("rt.sed");
        public static Score sedHurtInterval = new Score("rt.sed.hurtInterval");
        public static Score dieEvent = new Score("rt.dieEvent", "deathCount");
        public Score[] scores = {
            Return,
            corazonFrio,
            corazonFrioCooldown,
            sed,
            sedHurtInterval,
            dieEvent
        };
    }
}