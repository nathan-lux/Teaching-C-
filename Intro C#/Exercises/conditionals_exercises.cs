using System;

class ConditionalsExercises
{
    // we didn't cover enums yet but we will soon, for now you can just
    // reference values as we've discussed with the '.' 
    public struct BossResistances
    {
        public BossResistances(int frost, int fire, int lightning)
        {
            frostResistance = frost;
            fireResistance = fire;
            lightningResistance = lightning;
        }

        public int frostResistance;
        public int fireResistance;
        public int lightningResistance;
    }

    static void Main()
    {
        BossResistances bossRes = new BossResistances(10, 20, -5);
        // We've defined some boss damage resistance values above
        // you can access them in the following way
        Console.WriteLine("Boss Frost Resistance = " + bossRes.frostResistance);

        


    }
}