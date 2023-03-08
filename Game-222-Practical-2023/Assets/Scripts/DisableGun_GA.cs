using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableGun_GA : GameAction
{
    [SerializeField]
    private PerpetualShooter pShooter;

    public override void Action()
    {
        pShooter.enabled = false;   
    }
}
