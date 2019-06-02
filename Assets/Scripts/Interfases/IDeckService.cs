using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IDeckService : IDisposable
{

    List<Card> mixCards(List<Card> cards); // перемешать карты

}
