using System;

namespace V2.Labb1
{
    

    class Program
    {
        static void Main(string[] args)
        {

            //Consolen ger ut ett meddelande med 4st val

            Console.WriteLine("****************************************");
            Console.WriteLine("\nVälkommen till flygtidsberäknaren!\n");
            Console.WriteLine("Vilket flyg vill du se detaljerad information om? (svara med siffra)");
            Console.WriteLine("1. Stockholm - New York");
            Console.WriteLine("2. New York - Stockholm");
            Console.WriteLine("3. Avsluta programmet");
            Console.Write("Skriv ditt val här:");

            //Användaren får trycka på sitt val
            //Readkey() och KeyChar() låter oss få en input utan att klicka på enter

            char inputChar = Console.ReadKey().KeyChar;
            Console.WriteLine();

            // Avgångstider

            int stockholmHourDepart = 14;
            int stockholmMinuteDepart = 3;
            int newYorkHourDepart = 10;
            int newYorkMinuteDepart = 10;

            // Restid i timmar och minuter

            int travelHours = 7;
            int travelMinutes = 25;

            // Tidskillnad i timmar

            int timeDifference = 6;


            // Switchcase med alla alternativ användaren kan välja
            switch (inputChar)
            {
                case '1':
                    Console.WriteLine("****************************************");
                    Console.WriteLine("");
                    Console.WriteLine($"Avgångstid från Stockholm är {stockholmHourDepart:D2}:{stockholmMinuteDepart:D2}");
                    
                    // Ankomsttid i New York
                    // Tar avgångstiden från Sthlm och lägger på restid och drar av tidskillnad, först timmar sedan minuter

                    int newYorkHourArrival = stockholmHourDepart - timeDifference + travelHours;
                    int newYorkMinuteArrival = stockholmMinuteDepart + travelMinutes;
                   
                    // Skriver ut ankomst i formatet HH:mm
                    Console.WriteLine($"Din ankomsttid i New York är: {newYorkHourArrival:D2}:{newYorkMinuteArrival:D2}\n\n");
                    Console.WriteLine("****************************************\n");
                    Console.WriteLine("Programmet avslutas.");
                    Environment.Exit(0);
                    break;

                case '2':
                    Console.WriteLine("****************************************\n");
                    Console.WriteLine($"Avgångstid för ditt flyg är {newYorkHourDepart:D2}:{newYorkMinuteDepart:D2}\n");


                    // Ankomsttid i Stockholm
                    // Tar avgångstiden från NY och lägger på restid+tidsskillnad, först timmar sedan minuter
                    int stockholmHourArrival = newYorkHourDepart + timeDifference + travelHours;
                    int stockholmMinuteArrival = newYorkMinuteDepart + travelMinutes;
                   
                    Console.WriteLine($"Din ankomsttid i Stockholm är: {stockholmHourArrival:D2}:{stockholmMinuteArrival:D2}");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("****************************************\n");
                    Console.WriteLine("Programmet avslutas.");
                    Environment.Exit(0);
                    break;

                    // Trycker användaren på 3 avslutas programmet
                case '3':
                    Console.WriteLine("\nProgrammet avslutas.");
                    Environment.Exit(0);
                    break;

                     // Trycker användaren på något annat än 1-3 får man felmeddelande
                default:
                    Console.WriteLine("Ogiltigt val.\n");
                    Console.WriteLine("Programmet avslutas.");
                    Environment.Exit(0);
                    break;
            }
        }
    }
}
