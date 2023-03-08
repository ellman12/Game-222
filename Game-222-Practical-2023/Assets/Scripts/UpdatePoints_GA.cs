using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class UpdatePoints_GA : GameAction
{
    [SerializeField]
    private int points = 10;

    public static Action<int> UpdateScore = delegate { };
    public override void Action()
    {
        UpdateScore(points);
    }
}
