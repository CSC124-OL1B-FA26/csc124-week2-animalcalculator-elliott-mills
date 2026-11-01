Console.WriteLine(" === Animal Information === ");

Console.Write("Enter Animal Name: ");
string name = Console.ReadLine() ?? "Unknown";

Console.Write("How Many? ");
int count = Convert.ToInt32(Console.ReadLine());

Console.Write("Food per day (lbs): ");
double food = Convert.ToDouble(Console.ReadLine());

double dailyFood = count * food;
double weeklyFood = dailyFood * 7;

Console.WriteLine();
Console.WriteLine($"Animal: {name}");
Console.WriteLine($"Quantity: {count}");
Console.WriteLine($"Daily food: {dailyFood} lbs");
Console.WriteLine($"Weekly food: {weeklyFood} lbs");
