using System;

namespace Stacks
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack Deck = new Stack(52);
            Stack PlayerHand = new Stack(6);
            Stack ComputerHand = new Stack(6);
            Stack Crib = new Stack(4);
            string quit = "";
            while ( quit != "Q")
            {
                Console.WriteLine("press Q to quit or c to continue");
                Console.WriteLine("Do you want to add or remove");
                string answer = Console.ReadLine();


            }
        //    NewStack.AddToStack();

        }
    }
}
