// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("Введите имя");
Console.WriteLine(Console.ReadLine() + ", привет!");
int a = 5;
int b = 2;
Console.WriteLine(a + b);
Console.WriteLine(a / b);
Console.WriteLine();
Console.WriteLine("Введите имя");
string name = Console.ReadLine();
if(name.ToLower() == "сергей") {Console.WriteLine("Ну здравствуй, Сергей...");}
else {Console.WriteLine(name + ", привет!");}