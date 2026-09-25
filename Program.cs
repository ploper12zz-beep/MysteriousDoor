string secretcode = "1992";
string Attempts = "";

while (Attempts != secretcode)
{
    Console.Write("Enter the secret code: ");
    Attempts = Console.ReadLine();
}

Console.WriteLine("Access granted! The mysterious door opens...");