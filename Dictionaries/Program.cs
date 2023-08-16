//Exercises: Control Flow & Collections

//TODO: Write your code for Dictionary Practice below:

Console.WriteLine("Hello, Dictionary!");



Console.WriteLine("Enter your students' names and ID numbers (or ENTER to finish):");

Console.WriteLine("Student Name: ");
newStudent = Console.ReadLine();

if (newStudent != "")
{
    Console.WriteLine("ID: ");
    int newID = int.Parse(Console.ReadLine());
    students.Add(newID, newStudent);
}

Console.WriteLine("\nClass roster:");

foreach (KeyValuePair<int, string> student in students)
{
    Console.WriteLine(student.Value + "'s ID: " + student.Key);
}

Console.WriteLine("Number of students in roster: " + students.Count);
