using System;
using System.Reflection.Metadata;
//---------------------------------------------------------App Assignemnt Part 1------------------------------------------------
string[] cities =
{
    "Harare",
    "Bulawayo",
    "Chitungwiza",
    "Mutare",
    "Gweru",
    "Kwekwe",
    "Kadoma",
    "Masvingo",
    "Marondera",
    "Victoria Falls"
};

Console.WriteLine("Enter a character to add at the end of each city name:");
string input = Console.ReadLine();

// Use a for loop so we can modify the array by index
for (int a = 0; a < cities.Length; a++)
{
    cities[a] = cities[a] + input;
}

// Print updated cities
foreach (string city in cities)
{
    Console.WriteLine(city);
}

//---------------------------------------------------------------App Assignment Part 2------------------------------------------

int i = 0;

while (i < 5)
{
    Console.WriteLine(i);

    // FIX: Increment i so the condition (i < 5) will eventually become false.
    // Without this line, the loop runs forever because i never changes.
    i++;
}

Console.WriteLine("Loop finished successfully.");

//----------------------------------------------------------------App  Assignment Part 3----------------------------------------

Console.WriteLine("Loop using < operator:");

// This loop continues while i is LESS THAN 5
// It will run for values 0,1,2,3,4 (5 iterations total)
for (int p = 0; p < 5; p++)
{
    Console.WriteLine("i = " + p);
}

Console.WriteLine("\nLoop using <= operator:");

// This loop continues while i is LESS THAN OR EQUAL TO 5
// It will run for values 0,1,2,3,4,5 (6 iterations total)
for (int z = 0; z <= 5; z++)
{
    Console.WriteLine("i = " + z);
}


//--------------------------------------------------------------App Assignment Part 4-------------------------------------------
List<string> end_species = new List<string>()
{
"Baiji",
"WesternBlackRhinoceros",
"PintaIslandTortoise",
"ChristmasIslandPipistrelle",
"BrambleCayMelomys",
"Spix'sMacaw",
"Po'ouli",
"AlaotraGrebe",
"SmoothHandfish",
"Bachman'sWarbler"
};
Console.WriteLine("Can you name one specie that was declared extinct in the last 50 years: ");
string specie =  Console.ReadLine();
for (int s = 0; s < end_species.Count; s++)
{
    if (specie == end_species[s])
    {
        Console.WriteLine("That is correct. The " + end_species[s] + " is number " + (s + 1));

    }
   // else { Console.WriteLine("Not correct. Try again next time."); }
};

//--------------------------------------------------------------App Assignment Part 5-------------------------------------------
// Create a list with duplicate strings
List<string> fruits = new List<string>()
        {
            "Apple",
            "Banana",
            "Cherry",
            "Apple",
            "Grape",
            "Banana",
            "Mango"
        };

// Ask the user to enter text to search for
Console.WriteLine("Enter a fruit to search for in the list:");
string userInput = Console.ReadLine();

// Track if we found any matches
bool found = false;

// Loop through the list and check each element
for (int j = 0; j < fruits.Count; j++)
{
    if (fruits[j].Equals(userInput, StringComparison.OrdinalIgnoreCase))
    {
        Console.WriteLine($"Match found at index: {j}");
        found = true;
    }
}

// If no matches were found, inform the user
if (!found)
{
    Console.WriteLine("The text you entered is not on the list.");
}

//--------------------------------------------------------------App Assignment Part 6-------------------------------------------
// Step 1: Create a list of strings with at least two identical items
List<string> letters = new List<string>()
        {
            "A",
            "B",
            "C",
            "D",
            "C"  // duplicate
        };

// Step 2: Create a HashSet to keep track of items we have already seen
HashSet<string> seenItems = new HashSet<string>();

// Step 3: Iterate through each item in the list
foreach (string letter in letters)
{
    // Step 4: Check if the current item has already been seen
    if (seenItems.Contains(letter))
    {
        // If the item is in the HashSet, it's a duplicate
        Console.WriteLine(letter + " - this item is a duplicate");
    }
    else
    {
        // If the item is not in the HashSet, it's unique so far
        Console.WriteLine(letter + " - this item is unique");

        // Add the item to the HashSet so future duplicates can be detected
        seenItems.Add(letter);
    }
}

// Step 5: End of program
Console.WriteLine("Finished checking all items in the list.");
    