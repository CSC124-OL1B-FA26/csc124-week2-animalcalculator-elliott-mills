Console.WriteLine(" === Animal Information === ");

Console.Write("Enter Animal Name: ");
string name = Console.ReadLine();

Console.Write("How Many? ");
int count = Convert.ToInt32(Console.ReadLine());

Console.Write("Food per day (lbs): ");
double food = Convert.ToDouble(Console.ReadLine());

double totalFood = count * food;

Console.WriteLine($"\nAnimal: {name}");
Console.WriteLine($"Count: {count}");
Console.WriteLine($"Daily food: {totalFood} lbs");
