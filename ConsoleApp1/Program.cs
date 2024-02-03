// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


void Test(int age, string name = "asd")
{
    Console.WriteLine("My name is {0}, age is {1}", name, age);
}

Test(18, "Efim");