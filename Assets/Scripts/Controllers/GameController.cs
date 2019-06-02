using Assets.Scripts.Models;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public List<Player> players;
    // Use this for initialization
    void Start()
    {
        Initialize();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void Initialize()
    {
        players = new List<Player>() {
                new Player("Player 1"),
                new Player("Player 2"),
                new Player("Player 3")
            };
        Deck d = new Deck(players.Count);

        int k = 0;
        while (d.cards.Count > 0)
        {
            if (k > 100000) break;
            foreach(var player in players)
            {
                player.GetCard(d.LostCard());
            }
            k++;
        }
        int a = 1;
    }
}
