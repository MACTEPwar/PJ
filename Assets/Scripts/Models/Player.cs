using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.Models
{
    public class Player
    {
        List<Card> cards = new List<Card>();
        public string name;
        public int star;
        public Player(string name)
        {
            this.name = name;
            this.star = 3;
        }

        public void GetStar()
        {
            star++;
        }

        public void LoseStart()
        {
            star--;
        }

        public void GetCard(Card card)
        {
            cards.Add(card);
        }

        public void LoseCard(Card card)
        {
            for(int i = 0; i < cards.Count; i++)
            {
                if (cards[i].Value == card.Value)
                {
                    cards.RemoveAt(i);
                }
            }
        }
    }
}
