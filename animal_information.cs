Console.WriteLine(" === Animal Information === ");

Console.Write("Enter Animal Name: ");
string name = Console.ReadLine();

Console.Write("How Many? ");
int count = Convert.ToInt32(Console.ReadLine());

Console.Write("Food per day (lbs): ");
double food = Convert.ToDouble(Console.ReadLine());
double dailyFood = (Console.Readline(9));

double totalFood = count * food;
double weeklyFood = totalFood * 7;

Console.WriteLine($"\nAnimal: {name}");
Console.WriteLine($"Count: {count}");
Console.Writeline($"Daily food: {dailyFood} lbs");
Console.WriteLine($"Weekly food: {weeklyFood} lbs");
