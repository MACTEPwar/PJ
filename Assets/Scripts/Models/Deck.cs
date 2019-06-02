using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Deck
{

    public List<Card> cards = new List<Card>();
    private IDeckService deckService = null;

    //public GetCountCardsByValue(CardValue value)
    //{
    //    ca
    //}

    public Deck(int playerCount)
    {
        deckService = new DeckService();
        for (int i = 0; i < playerCount; i++)
        {
            cards.Add(new Card() { Value = CardValue.Stone });
            cards.Add(new Card() { Value = CardValue.Scissors });
            cards.Add(new Card() { Value = CardValue.Paper });
        }
        cards = deckService.mixCards(cards);
    }

    public Card LostCard()
    {
        var lastCard = cards.Last();
        cards.Remove(cards.Last());
        return lastCard;
    }
}
