Console.WriteLine("Please, select your gender (m/f):");

char userGender = Char.Parse(Console.ReadLine()); //loeb konsoolist maha andmeid string (sõne) formaadis
Console.WriteLine("Please, enter your last name");

string userLastName = Console.ReadLine();


if (userGender == 'm' )
{
    Console.WriteLine($"Welcome, Mr. {userLastName} !");
}
else if(userGender == 'f')
{
    Console.WriteLine($"Welcome, Ms. {userLastName}!");
}
else
{
    Console.WriteLine($"Welcome, {userLastName}!");
}

Console.WriteLine("Enter your age:");

int userAge = Int32.Parse(Console.ReadLine()); //"13" - heap, 13 - stack

if (userAge >= 13)
{
    Console.WriteLine("Welcome to Instagram");
}
else //if (userAge < 13)
{
    Console.WriteLine("You are too young to use Instagram");
}
