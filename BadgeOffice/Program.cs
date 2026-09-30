



//Part 1 hh


using System.Numerics;
using System.Runtime.InteropServices;

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


Console.WriteLine("Dorm x?");
double DormX = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Dorm y?");
double DormY = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Classroom x?");
double classRoomX = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Classroom y?");
double classRoomY = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Student's walking speed in feet per second?");
double studentSpeed = Convert.ToDouble(Console.ReadLine());

double totalX = classRoomX - DormX;
double totalY = classRoomY - DormY;

double squaredX = Math.Pow(totalX, 2);
double squaredY = Math.Pow(totalY, 2);

double numberBeforeSqaureroot = squaredX + squaredY;
double distance = Math.Sqrt(numberBeforeSqaureroot);

Console.WriteLine($"Distance: {distance.ToString("F1")} feet");

double tripInSeconds = distance / studentSpeed;
int minutes = (int)tripInSeconds/60;

int seconds = (int)tripInSeconds%60;

Console.WriteLine($"Walk Time: {minutes} minutes {seconds} seconds");

//Part 4 The Badge