# deckOfCards

The goal of this assignment is to practice many of the OOP ideas we went over in the previous tabs. We will be constructing three different classes: Card, Deck, and Player. That should give us the base foundation for creating just about any card game we want! This is a very important assignment, as these concepts are the essentials to working with classes, objects, and their associated methods. All future lecture and assignments will continue to build upon the concepts presented here as we continue through the course.

***To Do***

_create a class called "Card"_

1. Give the Card class a property "stringVal" which will hold the value of the card ex. (Ace, 2, 3, 4, 5, 6, 7, 8, 9, 10, Jack, Queen, King). This "val" should be a string.
2. Give the Card a property "suit" which will hold the suit of the card (Clubs, Spades, Hearts, Diamonds).
3. Give the Card a property "val" which will hold the numerical value of the card 1-13 as integers.
---
Next, create a class called "Deck"
1. Give the Deck class a property called "cards" which is a list of Card objects.
2. When initializing the deck, make sure that it has a list of 52 unique cards as its "cards" property.
3. Give the Deck a deal method that selects the "top-most" card, removes it from the list of cards, and returns the Card.
4. Give the Deck a reset method that resets the cards property to contain the original 52 cards.
5. Give the Deck a shuffle method that randomly reorders the deck's cards.

---
Finally, create a class called "Player"

1. Give the Player class a name property
2. Give the Player a hand property this is a List of type card. 
3. Give the Player a draw method of which draws a card from a deck, adds it to the player's hand and returns the Card. 
   1. Note: This method will require reference to a deck object. 
4. Give the Player a dfiscard method which discards the Card at the specified index from the player's hand and returns this Card or null if the index does not exist. 