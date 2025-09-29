void task1()
{
    Console.WriteLine("PLEASE ENTER YOUR NAME");
    string name = Console.ReadLine();
    Console.WriteLine("PLEASE ENTER YOUR AGE");
    int age = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine($"HELLO {name}, YOU ARE {age} YEARS OLD");
}
task1();
