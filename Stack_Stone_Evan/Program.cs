namespace Stack_Stone_Evan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program 22"); //writes program #

            //creates the myCardsArray array and assignes it with 8 cards
            Card[] myCardsArray = new Card[]
            {
                new Card("Ace", "Spades"),
                new Card("Jack", "Clubs"),
                new Card("Queen", "Diamonds"),
                new Card("King", "Spades"),
                new Card("10", "Hearts"),
                new Card("2", "Diamonds"),
                new Card("6", "Spades"),
                new Card("9", "Clubs"),
                new Card("Ace", "Diamonds"),
            };
             //creates the stack startingDeck, based on myCardsArray
            Stack<Card> startingDeck = new Stack<Card>(myCardsArray);
            
            //foreach card in the deck writes its card number and card suit, with an introduction 
            Console.WriteLine("Cards in Deck:");
            foreach(Card card in startingDeck)
            {
                Console.WriteLine($"The {card.Number} of {card.Suit}!");
            }

            Console.WriteLine($"Cards in the stack: {startingDeck.Count}");//writes the number of cards in the stack

            //creates the list, myHand, and adds three items to it
            List<Card> myHand = new List<Card>();
            myHand.Add(new Card("7", "Diamonds"));
            myHand.Add(new Card("Queen", "Hearts"));
            myHand.Add(new Card("2", "Spades"));

            Console.WriteLine("Got any 8's?"); //asks if there's any eights
            //if the count of startingDeck is greater than 0, add a item from startingDeck to myHand, and pop it
            if(startingDeck.Count > 0) 
            {
                myHand.Add(startingDeck.Pop());
            }
            
            Console.WriteLine($"Cards in the stack: {startingDeck.Count}");//writes the new count of the cards in the stack

            startingDeck.Push(myHand[0]);//addes an item to startingDeck with the key of 0 from myHand
            myHand.RemoveAt(0); //removes the item with key of 0 from myHand

            //new foreach card in deck, writes their card number and card suit, wiht introduction
            Console.WriteLine("Cards in Deck:");
            foreach (Card card in startingDeck)
            {
                Console.WriteLine($"The {card.Number} of {card.Suit}!");
            }
        }
    }
}