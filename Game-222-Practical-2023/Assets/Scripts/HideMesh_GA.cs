using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideMesh_GA : GameAction
{
    [SerializeField]
    private MeshRenderer mRenderer;

    public override void Action()
    {
        mRenderer.enabled = false;
    }
}
