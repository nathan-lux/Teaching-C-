using System;

class Variables
{
    static void Main()
    {
        // explicit typing
        int health = 100;
        float ukele_proc_prob = 0.38f;
        string char_name = "uplinked";
        char first_initial = 'a';
        bool has_killed_boss = false;

        // implicit typing (bad)
        var speed = 100;
        var speed_subtraction = 2;
        var damage = 'b';


        // game logic stuff
        Console.WriteLine(speed);

        // using variables
        // Console.WriteLine(char_name);
        // Console.WriteLine(first_initial);
        // Console.WriteLine(health);
        // Console.WriteLine(has_killed_boss);

        speed = speed - speed_subtraction;
        Console.WriteLine(speed);

        // have not killed boss
        Console.WriteLine(has_killed_boss);
        // you kill the boss
        has_killed_boss = true;
        Console.WriteLine(has_killed_boss);

    }
}

// int = integer e.g. 1, 2, 3, ... 100
// float (32 bit) = floating point integer e.g. 0.38f
// double (64 bit) = like a float but longer :) 

// string = just plain text inside "" (is literally a list of chars)
// char = single character values only, inside ''

// bool = literally just a true or false value, see conditionals later on

// arrays = array of ints [1, 2, 3, 4]
//          array of chars ['u', 'p', 'l', ...]
//          my_char_array[0] = 'u'