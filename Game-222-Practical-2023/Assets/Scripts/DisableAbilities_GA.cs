using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableAbilities_GA : GameAction
{
    [SerializeField]
    private PlayerAbilities pAbilities;

    public override void Action()
    {
        pAbilities.enabled = false;
    }
}
