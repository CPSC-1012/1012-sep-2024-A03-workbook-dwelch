// See https://aka.ms/new-console-template for more information
Console.WriteLine("\n\tPythagorean Theorem calculated using Math class\n");

const double POWER_OF_TWO = 2.0;
double height, baseLength = 0, hypotenuse;
string inputValue;
double measurementsSquared = 0.0;

Console.Write("Enter your triangle height:\t");
inputValue = Console.ReadLine();
height = double.Parse(inputValue);

Console.Write("Enter your triangle base:\t");
inputValue = Console.ReadLine();
baseLength = double.Parse(inputValue);

//order of operations in arithmetic
// (....)
// * and / left to right
// + and - left to right

measurementsSquared = (height * height);
measurementsSquared = measurementsSquared + Math.Pow(baseLength, POWER_OF_TWO);
hypotenuse = Math.Sqrt(measurementsSquared);

//measurementsSquared = (height * height);
//measurementsSquared += Math.Pow(baseLength, POWER_OF_TWO);
//hypotenuse = Math.Sqrt(measurementsSquared);

//measurementsSquared = (height * height) + Math.Pow(baseLength, POWER_OF_TWO);
//hypotenuse = Math.Sqrt(measurementsSquared);
//Refactoring

//hypotenuse = Math.Sqrt((height * height) + (Math.Pow(baseLength, POWER_OF_TWO)));

Console.WriteLine($"\nthe hypotenuse of height: {height} and base {baseLength} is: " +
    $"{hypotenuse}");
