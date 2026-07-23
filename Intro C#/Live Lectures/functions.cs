using System;

class Functions
{
    // Main() is a special kind of Function
    static void Main()
    {
        Console.WriteLine("hello world");

        int x = 4;
        int y = 12;
        int w = 9;

        // int z = x + y;
        int z = AddTwoNumbers(10, 2); // <- calling AddTwoNumbers
        Console.WriteLine("x + y = " + z);
        // Console.WriteLine("x + y = " + x + " + " + y + " = " + z);
        Console.WriteLine("w + y = " + AddTwoNumbers(w, y));

        string name = "uplinked";
        // PrintDecoratedName(name);
        string newName = DecorateName(name); 
        Console.WriteLine(newName);
        // after calling the above
    }

    public static string DecorateName(string name)
    {
        string decoratedName = "++ " + name + " ++";
        return decoratedName;
    }

    // What is a function (methods, routines)
    // separate piece of code that executes something repeatably
    // TAGS NAME(PARAMETERS) {

            // return x + y
    // }
    // f(x) = 0.5 * x + 1.0
    // f(1) = 0.5 * 1 + 1.0 = 1.5
    // f(2) == 1.0 + 1.0 = 2.0
    // Tags
    // public or private
    // - public means anybody can use this function
    // - private means only some people can use it
    public static int AddTwoNumbers(int x, int y)
    {
        int c = x + y;
        // do whatever else we want
        return c; // <--- the returned value (int -- MUST BE INT)
    }
    
    // Functions are way to call discrete blocks of code to execute specific,
    // well defined tasks
    // They need tags to setup, most importantly the return type
    // public/private RETURN_TYPE NAME(PARAMETERS) {
            // runs a bunch of code
            // returns a single value of type RETURN_TYPE
    // } 

    public static void PrintDecoratedName(string name)
    {
        string decorator = "~~";
        Console.WriteLine(decorator + name + decorator);
    }


}