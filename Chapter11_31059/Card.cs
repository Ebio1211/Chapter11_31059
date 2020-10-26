enum CardSuit
{
    Club, Spade, Heart, Diamond
}

class Card
{
    public CardSuit Suit { get; set; }
    public int Number { get; set; }

    public Card(CardSuit suit, int number)
    {
        Suit = suit;
        Number = number;
    }
}