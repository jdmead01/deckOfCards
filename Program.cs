using System;

namespace DeckOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            var myDeck = new Deck();
            myDeck.Deal();
            myDeck.Shuffle();
            myDeck.PrintShoe();
        }
    }
}
