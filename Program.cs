Console.WriteLine("Hey there! Welcome to Tortuga's Thrift Shop. I'm Tortuga.");
Console.WriteLine("What's your name?");

var name = Console.ReadLine();

double discount = name switch
{
    "Javier" => 0.5,
    _ => 1
};

Console.WriteLine("The following items are available:");
Console.WriteLine("1 - Rope");
Console.WriteLine("2 - Torches");
Console.WriteLine("3 - Climbing Equipment");
Console.WriteLine("4 - Clean Water");
Console.WriteLine("5 - Machete");
Console.WriteLine("6 - Canoe");
Console.WriteLine("7 - Food Supplies");
Console.WriteLine("What number do you want to see the price of?");

var choice = Convert.ToInt32(Console.ReadLine());

string answer = choice switch
{
    1 => $"Rope costs {10 * discount} gold",
    2 => $"Torches cost {15 * discount} gold",
    3 => $"Climbing Equipment costs {24 * discount} gold",
    4 => $"Clean Water costs {2 * discount} gold",
    5 => $"Machete costs {20 * discount} gold",
    6 => $"Canoe costs {200 * discount} gold",
    7 => $"Food Supplies cost {2 * discount} gold",
    _ => $"Apologies. I do not have an item associated with that option."
};

Console.WriteLine($"{answer}");