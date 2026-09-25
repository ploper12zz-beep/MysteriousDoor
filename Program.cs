string secretcode = "1992";
string Attempts = "";

while (Attempts != secretcode)
{
    Console.Write("Enter the secret code: ");
    Attempts = Console.ReadLine();
    if (Attempts != secretcode)
    {
        Console.WriteLine("Incorrect code. Please try again.\n");
    }
}

Console.WriteLine("Access granted! The mysterious door opens...");