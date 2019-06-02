using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card
{
    public CardValue Value { get; set; }
}

public enum CardValue
{
    Stone,
    Scissors,
    Paper
}
