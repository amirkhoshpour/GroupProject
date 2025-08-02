using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackBall
{
    public class GameManager
    {
        private Deck deck;
        private List<Player> players;
        private GameState gameState;

        public GameManager(List<Player> players)
        {
            this.players = players;
            this.deck = new Deck(players.Count);
            this.gameState = new GameState
            {
                CurrentRound = 1,
                TrumpSuit = "",
                LeadSuit = ""
            };
        }

        // Initializes and starts a new game
        public void StartGame()
        {
            // Game start logic, should include things like shuffling, hand clearing, scores, etc
        }

        // Starts a new round within the game
        public void StartRound()
        {
            // Deal cards, draw trump, reset bids, etc.
        }

        // Collects bids from all players
        public void CollectBids()
        {
            // Each player places a bid (human or AI)
        }

        // Plays one full trick (each player plays a card)
        public Player PlayTrick()
        {
            // Determine the winner of the trick
            return null; // Placeholder
        }

        // Updates scores after each round or trick
        public void UpdateScores()
        {
            // Based on bids and tricks won
        }

        // Moves to the next dealer/player
        public void NextDealer()
        {
            // Rotate dealer or update index
        }

        // Checks if the game has met the end condition
        public bool IsGameOver()
        {
            return false; // Placeholder
        }

        // Determines the final winner based on score
        public Player GetWinner()
        {
            return null; // Placeholder
        }

        // Getters and setters if needed
        public string TrumpSuit => gameState.TrumpSuit;
        public string LeadSuit => gameState.LeadSuit;
        public int CurrentRound => gameState.CurrentRound;
        public GameState State => gameState;
        public List<Player> Players => players;
    }

}
