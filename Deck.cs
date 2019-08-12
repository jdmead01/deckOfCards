using System;
using System.Collections.Generic;

namespace DeckOfCards
{
    class Deck
    {
        // When initializing the deck, make sure that it has a list of 52 unique cards as its "cards" property.
        private readonly string[]_faceTypes = {"Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King"};
        private readonly string[] _suitTypes = {"Clubs", "Hearts", "Diamonds", "Spades"};

        // Give the Deck class a property called "cards" which is a list of Card objects.
        public List<Card> Cards { get; set; }

        public Deck(bool jokers=false)
        {
            Cards = new List<Card>();
            Reset(jokers);

        }

        // Give the Deck a deal method that selects the "top-most" card, removes it from the list of cards, and returns the Card.
        public Card Deal()
        {   
            Card deal = Cards[0];
            Cards.Remove(deal);
            Console.WriteLine(deal);
            Console.WriteLine("Cards Remaining: " + Cards.Count);
            return deal;
        }

        // Give the Deck a reset method that resets the cards property to contain the original 52 cards.
        public void Reset(bool jokers=false)
        {
            Cards.Clear();
            foreach (var suitType in _suitTypes)
            {
                foreach (var faceType in _faceTypes)
                {
                    Cards.Add(new Card(faceType, suitType));
                }

            }
            if (jokers == true)
            {
                Cards.Add(new Card("Joker", "Joker"));
                Cards.Add(new Card("Joker", "Joker"));
            }
        }

        // Give the Deck a shuffle method that randomly reorders the deck's cards.
        public void Shuffle()
        {
            List<Card> ShuffledCards = new List<Card>();
            Random rand = new Random();
            while (Cards.Count > 0)
            {
                Card randCard = Cards[rand.Next(Cards.Count)];
                ShuffledCards.Add(randCard);
                Cards.Remove(randCard);
            }

            Cards = ShuffledCards;
            Console.WriteLine("Deck has been shuffled...");
        }

        public void PrintShoe()
        {
            foreach (var card in Cards)
            {
                Console.WriteLine(card);
            }

            Console.WriteLine("Total Count: " + Cards.Count);
        }

    }
}
