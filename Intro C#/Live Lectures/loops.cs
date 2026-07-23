using System;

class Loops
{
    static void Main()
    {
        //      index vals = {0, 1,  2, 3, 4}
        int[] damageValues = {5, 14, 8, 7, 9};

        // Console.WriteLine(damageValues[0]);
        // if i wanted to run the rest of the values i'd have to do this
        // damageValues[1];
        // damageValues[2];

        // inefficient, bad, especially for large matrices

        //  What it my iterator? int i = 0
        // i < damageValues.Length --> How many times do i want to run the loop?
        // i++ --> What does my iterator do at the end of each loop cycle
        for (int i = 0; i < damageValues.Length; i = i + 1)
        {
            Console.Write(i + " ");
            damageValues[i] = damageValues[i] + 2; 
        } // i++ -> i = i + 1
        Console.Write("\n");

        Console.WriteLine("For loop");
        for (int i = 0; i < damageValues.Length; i = i + 1)
        {
            Console.Write(damageValues[i] + " ");
        } 
        Console.Write("\n\n");

        // foreach loop
        Console.WriteLine("Foreach loop");
        foreach (int damage in damageValues)
        {
            Console.Write(damage + " ");
        }
        Console.Write("\n");

        // in foreach we define a local variable
        // int damage in damageValues -> damage = damageValues[i]

        // moves here after i == 4
    }

    // i = 0 (is i less than damageValues.Length?)              -> is 0 < 5?
    //       (if yes? Don't loop, skip... if No? Start loop)    -> 0 is < 5 so start loop
    // write to console damageValues[i]                         -> damageValues[0]
    // now increment i                                          -> i = 0 + 1 = 1
    // i = 1 (is less than length?)                             -> 1 < 5
    // write to console damageValues[i]                         -> damageValues[1] 14
    // ...
    // i = 4
    // write damageValues[4]
    // i = i + 1 = 5


    // Main()
    // {
    //      int a = 0;
    // }
    // variable a doesn't exist out here, only in the brackets
    // random code out here doesn't get run in Main()
}