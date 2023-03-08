using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableGameObject_GA : GameAction
{
    [SerializeField]
    private GameObject gObject;

    public override void Action()
    {
        gObject.SetActive(true);
    }
}
