int milesDriven; 
int gallonsUsed;
double mpg;

Console.Write("Enter the number of miles driven: ");
milesDriven = int.Parse(Console.ReadLine());

Console.Write("Enter the gallons of gas used: ");
gallonsUsed = int.Parse(Console.ReadLine());

mpg = (double)milesDriven / gallonsUsed;

Console.WriteLine($"The miles per gallon (MPG) is {mpg}");
