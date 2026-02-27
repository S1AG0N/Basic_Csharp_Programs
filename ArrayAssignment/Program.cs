using System;

//Pulling the names from a string array

string[] names = new string[] { "Prisca", "Phillip", "Patricia", "Steven", "Gift", "Patience", "Perpetua", "Tayana", "Noku", "Talia" };
Console.WriteLine("There are 10 names so use any random number between 1-10 to choose a name: ");
int number = int.Parse(Console.ReadLine());
if (number >= 1 && number <= 10)
{
    Console.WriteLine("The random name generated is: " + names[number - 1]);
}
else
{
    Console.WriteLine("the number you entered is outside the range");
}

    //Pulling a number from an array
    int[] numbers = new int[] { 742, 315, 908, 561, 284, 673, 490, 857, 126, 934 };
Console.WriteLine("Please enter any random number from 1-10:");
int position = int.Parse(Console.ReadLine());
if (position >= 1 && position <= 10)
{
    Console.WriteLine("Your lucky number is: " + numbers[position - 1]);
}
else
{
    Console.WriteLine("The number you have entered is out of range.");
}

//List of strings
List<string> list = new List<string>() {
    "Prisca",
    "Phillip",
    "Patricia",
    "Steven",
    "Gift",
    "Patience",
    "Perpetua",
    "Tayana",
    "Noku",
    "Talia" };
Console.WriteLine("Please enter the number to see the magic name:");
int num = int.Parse(Console.ReadLine());
Console.WriteLine("Tadaaaa: " + list[num - 1]);