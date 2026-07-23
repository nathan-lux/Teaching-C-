using System;

class FunctionExample
{
    static void Main()
    {
        string blue = "blue";
        string red = "red";
        string yellow = "yellow";
        string noColor = "none";

        // if character color is black, character color cannot be changed
        string black = "black";

        // starting color
        string currentColor = black;
        Console.WriteLine("Playor color is " + currentColor);

        // hit with blue beam
        currentColor = HitPlayerWithColor(blue, black); // <-- current color goes 
                                                        // from black to black
        Console.WriteLine("Player hit with blue beam, color is now " + currentColor);
        
        currentColor = HitPlayerWithColor(noColor, currentColor); // <-- current color goes 
                                                                  // from black to noColor
        Console.WriteLine("Player hit with noColor beam, color is now " + currentColor);

        currentColor = HitPlayerWithColor(blue, currentColor);
        Console.WriteLine("Player hit with blue beam, color is now " + currentColor);
    }

    public static string HitPlayerWithColor(string newColor, string currColor)
    {
        // want to say if color is black but new color is noColor, then reassign
        // if current color is black and new color is not noColor, then don't reassign
        // if the player isn't black, just reassign the color
        if (currColor == "black" && newColor == "none")
        {
            return "none";
        }
        else if (currColor == "black" && newColor != "none")
        {
            return "black";
        }
        else
        {
            return newColor;
        }

    }
}