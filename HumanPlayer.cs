using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackBall
{
    public class HumanPlayer : Player
    {
        public HumanPlayer(string name) : base(name)
        {
        }

        public override int PlaceBid(int maxBid)
        {
            Console.WriteLine($"{Name}, enter your bid (0 to {maxBid}): ");
            int bid;
            while (!int.TryParse(Console.ReadLine(), out bid) || bid < 0 || bid > maxBid)
            {
                Console.WriteLine($"Invalid input. Please enter a number between 0 and {maxBid}: ");
            }
            return bid;
        }

        public override Card PlayCard(Suit leadSuit, Suit trumpSuit)
        {
            Console.WriteLine($"{Name}, choose a card to play:");
            for (int i = 0; i < Hand.Count; i++)
            {
                Console.WriteLine($"{i}: {Hand[i]}");
            }

            int choice;
            while (!int.TryParse(Console.ReadLine(), out choice) || choice < 0 || choice >= Hand.Count)
            {
                Console.WriteLine("Invalid selection. Try again.");
            }

            Card selectedCard = Hand[choice];
            Hand.RemoveAt(choice);
            return selectedCard;
        }
    }
}
