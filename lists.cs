using System;

class Lists
{
    static void Main()
    {
        // what we did for arrays
        // TYPE[] = {}; where TYPE is like int, string, char, etc.
        // TYPE[] = new TYPE[LENGTH]

        // what do we do for lists?
        List<int> nums = new List<int>(); // <- empty, Lists must be empty to start

        // nums -> {}
        nums.Add(1);
        // nums -> {1}
        // Console.WriteLine(nums.Count);
        nums.Add(1);
        //nums -> {1, 1}
        // Console.WriteLine(nums.Count);
        // nums -> {1, 1, 3}
        nums.Add(3);
        // Console.WriteLine(nums[2]);

        nums.RemoveAt(2);
        // Console.WriteLine(nums[0]);

        List<string> fruits = new List<string>();
        fruits.Add("Apple");
        fruits.Add("Banana");
        fruits.Add("Orange");

        PrintList(fruits);
        
        string[] other_fruits = {"Durian", "Dragon Fruit"};
        fruits.AddRange(other_fruits);

        PrintList(fruits);

        fruits.Remove("Dragon Fruit");
        PrintList(fruits);

    }

    public static void PrintList<T>(List<T> myList)
    {
        // print all items in the fruits list
        foreach (T item in myList)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}