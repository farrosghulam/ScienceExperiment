int temp;

do
{
    Console.WriteLine("Please enter the temperature (must be between -50 and 150): ");
    temp = int.Parse(Console.ReadLine());

    if (temp < -50 || temp > 150)
    {
        Console.WriteLine("Invalid input. Temperature must be between -50 and 150! Please try again...");
    }
    else
    {
        Console.WriteLine($"Temperature recorded: {temp} °C");
    }

   switch (temp)
    {
        case < 0 and >= -50:
            Console.WriteLine("Category: Freezing");
            break;
        case >= 0 and <= 31:
            Console.WriteLine("Category:Normal");
            break;
        case > 31 and <= 100:
            Console.WriteLine("Category: Hot");
            break;
        case > 100 and <= 150:
            Console.WriteLine("Category: Extremely Hot");
            break;
    }        
} 
while (temp < -50 || temp > 150);

