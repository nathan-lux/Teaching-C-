using System;

class Lists
{
    static void Main()
    {
        // what we did for arrays
        // TYPE[] = {}; where TYPE is like int, string, char, etc.
        // TYPE[] = new TYPE[LENGTH]

        // what do we do for lists?
        // the 'new' command is a piece of syntax from C++
        // it tells C# to create a new instance of the list object
        // we name this list instance "nums" below
        List<int> nums = new List<int>(); // <- empty list assignment
                                          // note, no length built in

        // why use a list?
        // - Unlike arrays, lists have dynamic size
        // - Lists can store a more diverse set of objects 
        //      - (e.g. list of lists! or list of custom built objects)

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

    // this is a function, don't worry about it much for now, its just to
    // print lists
    public static void PrintList<T>(List<T> myList)
    {
        // print all items in the fruits list
        foreach (T item in myList)
        {
            Console.Write(item + ", ");
        }
        Console.WriteLine();
    }
}