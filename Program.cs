namespace ReferenceSwap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Elephant lucinda = new Elephant() { Name = "Lucinda", EarSize = 33 };
            Elephant lloyd = new Elephant() { Name = "Lloyd", EarSize = 40 };

                Console.Write("Press 1  for Lloyd, 2 for Lucinda, 3 to swap.");
            while (true)
            {
                char numChar = Console.ReadKey(true).KeyChar;
                    Console.WriteLine();
                    Console.WriteLine($"You pressed {numChar}");
                if (numChar == '3')
                {
                    Console.WriteLine("References have been swapped.");
                    (lucinda, lloyd) = (lloyd, lucinda);
                }
                else if (numChar == '1'|| numChar =='2')
                {
                    if (numChar == '1')
                    {
                        Console.WriteLine("Calling lloyd.WhoAmI()");
                        lloyd.WhoAmI();
                    }
                    else
                    {
                        Console.WriteLine("Calling lucinda.WhoAmI()");
                        lucinda.WhoAmI();
                    }
                }
                else
                {
                    return;
                }
            }

        }
    }
}