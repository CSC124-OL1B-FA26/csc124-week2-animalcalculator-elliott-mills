Console.WriteLine(" === Animal Information === ");

Console.Write("Enter Animal Name");
string name = Console. ReadLine ();

Console.Write("How Many? ");
int count = Convert.ToDoble(Console.Readline());

Console.Write("Food per day (lbs): ");
double food = Convert.ToDouble(Console.Readline());

double totalFood = count * food;

Console.WriteLine($"\nAnimal: {name}");
Console.WriteLine($"Count: {count}");
Console.WriteLine($"Daily food: {totalFood} lbs");
