using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackBall
{
    public class AIPlayer : Player
    {
        public AIPlayer(string name) : base(name)
        {
        }

        public override int PlaceBid(int maxBid)
        {
            // TODO: Implement AI bidding logic
            return 0;
        }

        public override Card PlayCard(Suit leadSuit, Suit trumpSuit)
        {
            // TODO: Implement AI card selection logic
            var selectedCard = Hand[0];
            Hand.RemoveAt(0);
            return selectedCard;
        }
    }

}
