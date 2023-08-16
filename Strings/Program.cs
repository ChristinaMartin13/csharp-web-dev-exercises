//Exercises: Control Flow & Collections

//TODO: Write your code for String Practice below:

Console.WriteLine("Hello, Strings!");

string drSeuss = "I would not, could not, in a box. I would not, could not with a fox." +
    "I will not eat them in a house. I will not eat them with a mouse.";

string[] wordArray = drSeuss.Split(" ");

Console.WriteLine(string.Join(",", wordArray));

string[] arrayTwo = drSeuss.Split(".");

Console.WriteLine(string.Join("\n", arrayTwo));