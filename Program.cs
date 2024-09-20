namespace NumbersGame_Sami_Harun_Klass_NET24
{
    internal class Program
    {
        static void Main(string[] args)
        {

                // Välkomstmeddelande
                Console.WriteLine("Välkommen! Jag tänker på ett nummer. Kan du gissa vilket? Du får fem försök.");

                // Generera ett slumpmässigt nummer mellan 1 och 20
                Random random = new Random();
                int randomNum = random.Next(1, 21);

                // Användaren får max 5 försök
                int maxAttempts = 5;
                bool isCorrectGuess = false;

                // Loop för att tillåta upp till 5 gissningar
                for (int attempt = 1; attempt <= maxAttempts; attempt++)
                {
                    Console.WriteLine($"Försök {attempt}/{maxAttempts}: Gissa ett nummer:");
                    int guess = Convert.ToInt32(Console.ReadLine());

                    // Anropa funktionen för att kontrollera gissningen
                    if (CheckGuess(guess, randomNum))
                    {
                        isCorrectGuess = true;
                        break;
                    }
                }

                // Om användaren inte gissat rätt på fem försök
                if (!isCorrectGuess)
                {
                    Console.WriteLine("Tyvärr, du lyckades inte gissa talet på fem försök!");
                    Console.WriteLine($"Det rätta talet var: {randomNum}");
                }

                // Vänta på att användaren trycker på en knapp innan programmet avslutas
                Console.ReadKey();
            }

            // Funktion för att kontrollera om gissningen är rätt
            static bool CheckGuess(int guess, int randomNum)
            {
                if (guess > randomNum)
                {
                    Console.WriteLine("Tyvärr, du gissade för högt!");
                    return false;
                }
                else if (guess < randomNum)
                {
                    Console.WriteLine("Tyvärr, du gissade för lågt!");
                    return false;
                }
                else
                {
                    Console.WriteLine("Wohoo! Du klarade det!");
                    return true;
                }
            }
        }
    }


