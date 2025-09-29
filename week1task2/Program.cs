void task2()
{
    
    Console.WriteLine("PLEASE ENTER YOUR AGE");
    int age = Convert.ToInt32(Console.ReadLine());
    if ( age<13)
    {
     
        Console.WriteLine("You are a child");
    }
    else if (age>=13 && age<20)
    {
        Console.WriteLine("You are a teenager");
    }
    else if (age>=20 && age<65)
    {
        Console.WriteLine("You are an adult");
    }
    else
    {
        Console.WriteLine("You are a senior citizen");
    }



}
task2();
