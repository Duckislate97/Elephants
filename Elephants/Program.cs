namespace Elephants
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Elephant lucinda = new Elephant() { Name = "Lucinda", EarSize = 33 };
            Elephant lloyd = new Elephant() { Name = "Lloyd", EarSize = 40 };

            Console.WriteLine("Press 1 for Lloyd, 2 for Lucinda, 3 to swap, 4 to mess up the whole thing, 0 to exit");

            while (true)
            {
                string line = Console.ReadLine();

                if (int.TryParse(line, out int number))
                {
                    if (number == 1)
                    {
                        Console.WriteLine("You pressed 1\nCalling lloyd.WhoAmI");

                        lloyd.WhoAmI();
                    }
                    else if (number == 2)
                    {
                        Console.WriteLine("You pressed 2\nCalling lucinda.WhoAmI");

                        lucinda.WhoAmI();
                    }
                    else if (number == 3)
                    {
                        Console.WriteLine("You pressed 3\nReferences have been swapped");

                        SwapReferences(ref lucinda, ref lloyd);
                    }
                    else if(number == 4)
                    {
                        lloyd = lucinda;

                        lucinda.EarSize = 4321;

                        lloyd.WhoAmI();
                    }
                    else if (number == 0)
                    {
                        Console.WriteLine("Terminating program");

                        break;
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid number");
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a number");
                }
            }
        }

        static void SwapReferences(ref Elephant elephant1, ref Elephant elephant2)
        {
            Elephant temp = elephant1;

            elephant1 = elephant2;

            elephant2 = temp;
        }
    }
}
