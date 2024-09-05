Console.WriteLine("Användarnamn");
string name = Console.ReadLine();
name = name.ToLower();

if (name.ToLower() == "Nguyen" || name == "martin")
{
    Console.WriteLine("Välkommen!");
}
else if (name == "martin")
{
    Console.WriteLine("Välkommen!");
}
else
{
        Console.WriteLine("FU");
}

Console.ReadLine();