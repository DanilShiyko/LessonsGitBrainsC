// See https://aka.ms/new-console-template for more information
Console.WriteLine("Как тебя зовут?");
string username = Console.ReadLine();


if (username.ToLower() == "danil")
{
    Console.WriteLine($"Привет, {username}! Как поживаешь?");
}
else 
{ 
    Console.WriteLine("Я тебя не знаю!"); 
}


Console.ReadLine();