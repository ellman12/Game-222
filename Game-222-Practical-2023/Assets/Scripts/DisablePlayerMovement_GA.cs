using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisablePlayerMovement_GA : GameAction
{
    [SerializeField]
    private PlayerMovement pMovement;

    public override void Action()
    {
        pMovement.enabled = false;
    }
}
