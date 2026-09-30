



//Part 1 hh


Console.WriteLine("What is your full name");
string originalName = Console.ReadLine().Trim().ToUpper();
Console.WriteLine($"Name on badge: {originalName}");

int spacePosition = originalName.IndexOf(" ");
string firstName = originalName.Substring(0, spacePosition);
string lastName = originalName.Substring(spacePosition + 1);

string userNameP1 = originalName.Substring(0,1);
string lastNameInitial = lastName.Substring(0,1);



Console.WriteLine($"Username:  {userNameP1}{lastName}");

Console.WriteLine($"Initals: {userNameP1}.{lastNameInitial}");

int nameLength = lastName.Length;


Console.WriteLine($"Letters in last name: {nameLength}");

//Part 2 


Random rng = new Random();

int id = rng.Next(100000, 1000000);
int locker = rng.Next(1,501);

Console.WriteLine($"Student ID: {id}");
Console.WriteLine($"Locker: {locker}");


//Part 3