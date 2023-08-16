//Exercises: Control Flow & Collections

//TODO: Write your code for Array Practice below:

Console.WriteLine("Hello, Arrays!");

int[] myArray = { 1, 1, 2, 3, 5, 8 };

foreach (int i in myArray)
{
    Console.WriteLine(i);
}

foreach (int i in myArray)
{
    if (i%2 != 0) { 
        Console.WriteLine(i);
    }
}

