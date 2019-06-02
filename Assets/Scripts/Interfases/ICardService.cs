using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ICardService : IDisposable
{
    void Show(); // повернуть чтобы показать карту
    void Hide(); //повернуть чтобы скрыть
    void MoveTo(Vector2 toPoint); // двигать карту в точку
}
