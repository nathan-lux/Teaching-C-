using System;

class Variables
{
    static void Main()
    {
        // explicit typing
        int health = 100;               // integer variable (1, 2, 3, etc.)
        float ukele_proc_prob = 0.38f;  // float variable (decimal numbers)
        string char_name = "uplinked";  // string variable (a string or list of chars)
        char first_initial = 'a';       // char variable (single character must use '')
        bool has_killed_boss = false;   // bool variable (true or false, binary value)
        double trouble = 0.00007;       // double variable (64-bit, floats but longer)

        // implicit typing 
        var speed = 100;                // C# can implicitly tell what your variable type 
        var speed_subtraction = 2;      // is using 'var' but it is best to avoid this early
        var damage = 'b';               // in favor of keeping your code explicit and readable

        // game logic stuff goes here
        Console.WriteLine("Speed before deductino: " + speed + "\t" + speed_subtraction);

        // printing variables uncomment to see console output
        // Console.WriteLine(char_name);
        // Console.WriteLine(first_initial);
        // Console.WriteLine(health);
        // Console.WriteLine(has_killed_boss);

        // reassigning a variable value does not require the type statement since
        // the variable is already instantiated in Main()
        speed = speed - speed_subtraction;
        Console.WriteLine("Speed after deduction: " + speed);

        // have not killed boss
        Console.WriteLine("Has the player killed the boss? " + has_killed_boss);
        // you kill the boss
        has_killed_boss = true;
        Console.WriteLine("What about now? " + has_killed_boss);

        // defining multiple variables of the same name
        // DECLARATION          -> int speed;
        // ASSIGNMENT           -> speed = 10;

        // cannot declare two variables of the same name
        // int speed = 10;
        // string speed = "speed";

        // Strings
        Console.WriteLine("Current Speed " + speed);

        // Quick mafs
        speed = speed - speed_subtraction;
        speed -= speed_subtraction;
        speed += speed_subtraction;
    }
}

// int = integer e.g. 1, 2, 3, ... 100
// float (32 bit) = floating point integer e.g. 0.38f
// double (64 bit) = like a float but longer :) 

// string = just plain text inside "" (is literally a list of chars)
// char = single character values only, inside ''

// bool = just a true or false value, see conditionals later on

// arrays = array of ints [1, 2, 3, 4]
//          array of chars ['u', 'p', 'l', ...]
//          my_char_array[0] = 'u'