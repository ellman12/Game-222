using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleCollider_GA : GameAction
{
    [SerializeField]
    private Collider localCollider;

    public override void Action()
    {
        if(localCollider.enabled)
            localCollider.enabled = false; 
        else
            localCollider.enabled = true;
    }
}
