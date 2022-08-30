Console.WriteLine ("enter 3-digit number ");
try
{
    int x = Convert.ToInt32 (Console.ReadLine());
    int b = x / 100;
    Console.WriteLine ("First digit is "+b);
}
catch
{
    Console.WriteLine ("It is not a 3-digit number");
}