using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeckService : IDeckService {
    public List<Card> mixCards(List<Card> cards)
    {
        for (int i = 0; i < cards.Count; i++)
        {
            Card tmp = cards[i];
            cards.RemoveAt(i);
            cards.Insert(Random.Range(0,cards.Count), tmp);
        }

        return cards;
    }

    public void Dispose()
    {

    }
}
