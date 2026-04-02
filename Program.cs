// Display welcome message to the user
Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

// Prompt the user to enter the package weight
Console.WriteLine("Please enter the package weight:");
// Read the input from the user and convert it to a double
double weight = Convert.ToDouble(Console.ReadLine());

// Check if the package is too heavy to ship
if (weight > 50)
{
    // Display error message and exit program if weight exceeds 50
    Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
    return; // Ends the program
}

// Prompt the user to enter the package width
Console.WriteLine("Please enter the package width:");
// Read input and convert to double
double width = Convert.ToDouble(Console.ReadLine());

// Prompt the user to enter the package height
Console.WriteLine("Please enter the package height:");
// Read input and convert to double
double height = Convert.ToDouble(Console.ReadLine());

// Prompt the user to enter the package length
Console.WriteLine("Please enter the package length:");
// Read input and convert to double
double length = Convert.ToDouble(Console.ReadLine());

// Calculate the total of all dimensions
double totalDimensions = width + height + length;

// Check if the total dimensions exceed the allowed limit
if (totalDimensions > 50)
{
    // Display error message and exit program if dimensions exceed 50
    Console.WriteLine("Package too big to be shipped via Package Express.");
    return; // Ends the program
}

// Calculate shipping quote: (width * height * length * weight) / 100
double quote = (width * height * length * weight) / 100;

// Display the shipping quote formatted to 2 decimal places
Console.WriteLine("Your estimated total for shipping this package is: $" + quote.ToString("F2"));

// Display thank you message
Console.WriteLine("Thank you!");
