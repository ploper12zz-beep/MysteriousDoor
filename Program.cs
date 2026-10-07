string secretcode = "1992";
string Attempts = "";

int trylimit = 3;

while (Attempts != secretcode && trylimit > 0)
{
    Console.Write("Enter the secret code: ");
    Attempts = Console.ReadLine();
    if (Attempts != secretcode)
    {
        trylimit--;
        Console.WriteLine($"Incorrect code. Please try again. You have {trylimit} attempts left.\n");
    }
    else
    {
        Console.WriteLine("Access granted! The mysterious door opens...");
    }
}
