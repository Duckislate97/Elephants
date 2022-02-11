namespace Elephants
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Elephant lucinda = new Elephant() { Name = "Lucinda", EarSize = 33 };
            Elephant lloyd = new Elephant() { Name = "Lloyd", EarSize = 40 };

            Console.WriteLine("Press 1 for Lloyd, 2 for Lucinda, 3 to swap, " +
                "4 to mess up the whole thing, \n5 to make them chat, " +
                "6 to generate an array of elephants, 0 to exit");

            while (true)
            {
                char input = Console.ReadKey(true).KeyChar;

                Console.WriteLine("\nYou pressed " + input);

                if (input == '1')
                {
                    Console.WriteLine("Calling lloyd.WhoAmI");

                    lloyd.WhoAmI();
                }
                else if (input == '2')
                {
                    Console.WriteLine("Calling lucinda.WhoAmI");

                    lucinda.WhoAmI();
                }
                else if (input == '3')
                {
                    Console.WriteLine("References have been swapped");

                    SwapReferences(ref lucinda, ref lloyd);
                }
                else if (input == '4')
                {
                    lloyd = lucinda;

                    lucinda.EarSize = 4321;

                    lloyd.WhoAmI();
                }
                else if (input == '5')
                {
                    lucinda.SpeakTo(lloyd, "Hi, Lloyd!");
                }
                else if(input == '6')
                {
                    Elephant[] elephants = new Elephant[7];

                    elephants[0] = new Elephant() { Name = "Lloyd", EarSize = 40 };
                    elephants[1] = new Elephant() { Name = "Lucinda", EarSize = 33 };
                    elephants[2] = new Elephant() { Name = "Larry", EarSize = 42 };
                    elephants[3] = new Elephant() { Name = "Lucille", EarSize = 32 };
                    elephants[4] = new Elephant() { Name = "Lars", EarSize = 44 };
                    elephants[5] = new Elephant() { Name = "Linda", EarSize = 37 };
                    elephants[6] = new Elephant() { Name = "Humphrey", EarSize = 45 };

                    for(int i = 0; i < elephants.Length; i++)
                    {
                        Console.WriteLine("\nElephant " + (i + 1) + ":");

                        elephants[i].WhoAmI();
                    }

                    PrintBiggestEars(elephants);
                }
                else if (input == '0')
                {
                    Console.WriteLine("Terminating program");

                    break;
                }
                else
                {
                    Console.WriteLine("Please enter a vald number");
                }
            }
        }

        static void SwapReferences(ref Elephant elephant1, ref Elephant elephant2)
        {
            Elephant temp = elephant1;

            elephant1 = elephant2;

            elephant2 = temp;
        }

        static void PrintBiggestEars(Elephant[] elephants)
        {
            Elephant biggestEars = elephants[0];

            for(int i = 0; i < elephants.Length; i++)
            {
                if (elephants[i].EarSize > biggestEars.EarSize)
                {
                    biggestEars = elephants[i];
                }
            }

            Console.WriteLine("\n" + biggestEars.Name + "'s ears are the biggest, at " + biggestEars.EarSize + " inches.");
        }
    }
}
