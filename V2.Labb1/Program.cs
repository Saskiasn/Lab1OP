namespace V2.Labb1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("****************************************");
        Console.WriteLine();
        Console.WriteLine("Välkommen till flygtidsberäknaren!");
        Console.WriteLine();
        Console.WriteLine("Vilket flyg vill du se detaljerad information om? (svara med siffra)");
        Console.WriteLine("1. Stockholm - New York");
        Console.WriteLine("2. New York - Stockholm");
        Console.WriteLine("3. Avsluta programmet");
        Console.Write("Skriv ditt val här:");


        // Read user input
        string userInput = Console.ReadLine();
        Console.WriteLine();

        switch (userInput)
        {
            case "1":
                Console.WriteLine("Du har valt flyget från Stockholm till New York.");
                Console.WriteLine("Flygtiden är cirka 8 timmar och 30 minuter.");
                break;

            case "2":
                Console.Writeline("Du har valt flyget från New York till Stockholm.");


        }
        Console.WriteLine($"Ditt flygg till {userInput} ")
            Console.WriteLine("test");
        Console.WriteLine("test");

    }
}

