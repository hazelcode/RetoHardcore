using SteveSharp.Core;

namespace RetoHardcore
{
    public class RT
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
        public Score Return = new Score("rt.return");
        public Score corazonFrio = new Score("rt.corazonFrio", "used:warped_fungus_on_a_stick");
        public Score corazonFrioCooldown = new Score("rt.corazonFrio.Cooldown");
        public Score sed = new Score("rt.sed");
        public Score sedHurtInterval = new Score("rt.sed.hurtInterval");
        public Score dieEvent = new Score("rt.dieEvent", "deathCount");
        public Score[] scores = {
            new Score("rt.return"),
            new Score("rt.corazonFrio", "used:warped_fungus_on_a_stick"),
            new Score("rt.corazonFrio.Cooldown"),
            new Score("rt.sed"),
            new Score("rt.sed.hurtInterval"),
            new Score("rt.dieEvent", "deathCount")
        };
    }
}