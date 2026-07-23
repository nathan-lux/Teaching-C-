using System;

class Conditions
{
    static void Main()
    {
        // Intro to boolean logic and boolean operators
        Console.WriteLine(!true);   // <- The ! is the "not" or negation operator

        int a = 1;
        int b = 2;
        int c = 5;
        int d = 7;
        int e = 7;

        // a > b -> is a greater than b? i.e. is this statement true or false
        // boolean operations essentially ask the computer a question about two pieces of data
        // and how they relate to one another
        bool a_greater_than_b  = (a > b);  // False
        bool a_equal_to_b      = (a == b); // False
        bool d_greater_than_e  = (d > e);  // False
        bool d_geq_e           = (d >= e); // True
        bool d_leq_e           = (d <= e); // True

        // bool d_equal_to_e      = (d == e); // True
        bool d_equal_to_e      = (d != e); // False

        // (is a greater than b) AND (d greater or equal to e) -> False
        bool joint_condition1 = (a > b) && (d >= e); // && == AND
        // (is a greater than b) OR ( d greater or equal to e) -> True
        bool joint_condition2 = (a > b) || (d >= e); // || == OR

        bool third_condition = (joint_condition1) && (joint_condition2); // -> False
        bool fourth_condition = (joint_condition1) || (joint_condition2); // -> True

        // probably means you've done something wrong - ie defined too many boolean 
        // dependent things or too many conditional statements.
        bool fifth_condition = ((a > b) && (d >= e)) || ((a > b) || (d <= e));
        
        // True AND False   -> False
        // True AND True    -> True
        // False AND False  -> True
        // True OR False    -> True
        // True OR True     -> True
        // False or False   -> False

        // #################################### //
        //              IF STATEMENTS           //
        // #################################### //

        // If statements are one of the most powerful tools at our disposal
        // They follow the format below
        // IF (<CONDITION> == TRUE) {
        //      <EXECUTE CODE IN BRACKETS>
        //  }
        // We can combine them with the boolean logic we learned above 

        // player related values
        int health = 100;
        bool player_hit_boss = true;

        // boss related values
        bool boss_hit_player = false;
        int boss_damage = 20;
        int boss_health = 0;

        // if the bosses health drops below zero, do victory message
        if (boss_health <= 0) // <-- compare boss health to zero
        {
            Console.WriteLine("Victory Screech");
        }

        // print special message if player is not damaged boss and boss is dead
        if ((boss_hit_player == false) && (boss_health <= 0))
        {
            Console.WriteLine("gaddamn");
        } 
        else if ((boss_hit_player == true) && (boss_health <= 0)) // < --- This one is True
        {
            Console.WriteLine("Twas a hard fought battle, but you have won");
        }
        else if ((boss_hit_player == true) && (boss_health > 0))
        {
            Console.WriteLine("You've been hit! and the boss is not dead");
        } 
        else
        {
            // Do whatever in here
            // raise the alarms you shouldn't be here
        }

        // if one of the conditions gets met, it will exit the entire block of ifs and elses
        // if none get met, it will end in the last else, then continue executing code top 
        // to bottom

    }
}

