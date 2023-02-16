using GameActions;
using UnityEngine;

public class ToggleMesh_GA : GameAction
{
    [SerializeField] private bool disable;
    [SerializeField] private MeshRenderer meshRenderer;

    public override void Action() => meshRenderer.enabled = !disable;
}