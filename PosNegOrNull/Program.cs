Console.WriteLine("Type in a number and I will tell you if it is Positive, Negative, or 0.");
int Number = Convert.ToInt32(Console.ReadLine());
if (Number > 0)
{
    Console.WriteLine("The chosen number is Positive.");
}
else if (Number < 0)
{
    Console.WriteLine("The chosen number is Negative");
}
else 
{
    Console.WriteLine("The chosen number is Zero");
}
Console.WriteLine("Press any key to exit.");
Console.ReadKey();
