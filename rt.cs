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
        public static Score ReturnSt = new Score("rt.return");
        public Score Return = new Score("rt.return");
        public static Score corazonFrioSt = new Score("rt.corazonFrio", "used:warped_fungus_on_a_stick");
        public Score corazonFrio = new Score("rt.corazonFrio", "used:warped_fungus_on_a_stick");
        public static Score corazonFrioCooldownSt = new Score("rt.corazonFrio.Cooldown");
        public Score corazonFrioCooldown = new Score("rt.corazonFrio.Cooldown");
        public static Score sedSt = new Score("rt.sed");
        public Score sed = new Score("rt.sed");
        public static Score sedHurtIntervalSt = new Score("rt.sed.hurtInterval");
        public Score sedHurtInterval = new Score("rt.sed.hurtInterval");
        public static Score dieEventSt = new Score("rt.dieEvent", "deathCount");
        public Score dieEvent = new Score("rt.dieEvent", "deathCount");
        public Score[] scores = {
            ReturnSt,
            corazonFrioSt,
            corazonFrioCooldownSt,
            sedSt,
            sedHurtIntervalSt,
            dieEventSt
        };
    }
}