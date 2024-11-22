namespace V2.Labb1
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****************************************");
            Console.WriteLine("\nVälkommen till flygtidsberäknaren!\n");
            Console.WriteLine("Vilket flyg vill du se detaljerad information om? (svara med siffra)\n");
            Console.WriteLine("1. Stockholm - New York");
            Console.WriteLine("2. New York - Stockholm");
            Console.WriteLine("3. Avsluta programmet\n");
            Console.Write("Skriv ditt val här: ");

            char inputChar = Console.ReadKey().KeyChar;
            Console.WriteLine();

            // Tider och tidsinställningar
            int stockholmHourDepart = 14;
            int stockholmMinuteDepart = 3;
            int newYorkHourDepart = 10;
            int newYorkMinuteDepart = 10;

            int travelHours = 7;
            int travelMinutes = 25;

            // Tidskillnad
            int timeDifference = 6;

            switch (inputChar)
            {
                case '1':
                    Console.WriteLine("Du har valt flyget från Stockholm till New York.\n");
                    Console.WriteLine($"Avgångstid för ditt flyg är {stockholmHourDepart:D2}:{stockholmMinuteDepart:D2}\n");
                    // Ankomsttid i New York
                    int newYorkHourArrival = stockholmHourDepart - timeDifference + travelHours;
                    int newYorkMinuteArrival = stockholmMinuteDepart + travelMinutes;
                    if (newYorkMinuteArrival >= 60)
                    {
                        newYorkMinuteArrival -= 60;
                        newYorkHourArrival++;
                    }
                    Console.WriteLine($"Din ankomsttid i New York är: {newYorkHourArrival:D2}:{newYorkMinuteArrival:D2}");
                    break;

                case '2':
                    Console.WriteLine("Du har valt flyget från New York till Stockholm.\n");
                    Console.WriteLine($"Avgångstid för ditt flyg är {newYorkHourDepart:D2}:{newYorkMinuteDepart:D2}\n");
                    // Ankomsttid i Stockholm
                    int stockholmHourArrival = newYorkHourDepart + timeDifference + travelHours;
                    int stockholmMinuteArrival = newYorkMinuteDepart + travelMinutes;
                    if (stockholmMinuteArrival >= 60)
                    {
                        stockholmMinuteArrival -= 60;
                        stockholmHourArrival++;
                    }
                    Console.WriteLine($"Din ankomsttid i Stockholm är: {stockholmHourArrival:D2}:{stockholmMinuteArrival:D2}");
                    break;

                case '3':
                    Console.WriteLine("Programmet avslutas.");
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Ogiltigt val.");
                    break;
            }
        }
    }
}
