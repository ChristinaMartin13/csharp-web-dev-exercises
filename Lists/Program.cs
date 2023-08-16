//Exercises: Control Flow & Collections

//TODO: Write your code for List Practice below:

Console.WriteLine("Hello, Lists!");

static int sumEven(List<int> collection)
{
    int total = 0;
    foreach (int item in collection)
    {
        if (item%2 == 0)
        {
            total += item;
        }
    }
    return total;
}

//Create a list with at least 10 integers and call your method on the list.

List<int> collection = new List<int> { 0, 4, 13, 6, 12, 27, 8, 14, 10, 1 };

int evenSum = sumEven(collection);

Console.WriteLine(evenSum);

//Write a static method to print out each word in a list that has exactly 5 letters.

static void fiveLetterWords(List<string>collection)
{
    foreach(string word in collection)
    {
       if (word.Length == 5)
        {
          Console.WriteLine(word);
        }
    }
}



Console.WriteLine("Enter a word length: ");
string input = Console.ReadLine();
int numChars = int.Parse(input);

xLetterWord(wordlist, numChars);

static void xLetterWord(List<string> wordlist, int length)
{
    foreach (string word in wordlist)
    {
        if(word.Length == length)
        {
            Console.WriteLine(word);
        }
    }
}

