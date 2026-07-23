using System;

class Arrays
{
    static void Main()
    {
        // SHORTCOMINGS?
        // Arrays are fixed size
        // Arrays cannot contain more than one data type

        // Plus side
        // Easy, compact and fast as all getout

        // Syntax for declaring arrays
        // TYPE[] = {}; where TYPE is like int, string, char, etc.
        // TYPE[] = new TYPE[LENGTH]

        //           { 0, 1, 2, 3, 4, 5 }
        int[] nums = { 1, 2, 3, 4, 5, 6 };
        int[] nums2 = new int[10]; // <= empty array of ints, 10 vals long

        //                  { 0,        1,          2}
        string[] strings = {"apple", "orange", "banana"};

        Console.WriteLine(nums[3]);
        Console.WriteLine(strings[2]);

        int[,] matrix = { {1, 2}, 
                          {3, 4}  };

        Console.WriteLine(matrix[0, 1]);
        matrix[0, 1] = 7;
        Console.WriteLine(matrix[0, 1]);

        Console.WriteLine(nums2.Length);
    }
}