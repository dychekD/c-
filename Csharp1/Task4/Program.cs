try
{
    Console.WriteLine ("enter positive integer ");
    int x = Convert.ToInt32 (Console.ReadLine());
    int b = -x;
    while (b<=x)
    {
        Console.Write (b+",");
        b++;
    }
}
catch 
{
    Console.WriteLine ("it is not a positive integer");
}