using GameActions;
using UnityEngine;

public class GameObjectToggle_GA : GameAction
{
    [SerializeField] private bool disable;
    [SerializeField] private new GameObject gameObject;

    public override void Action() => gameObject.SetActive(!disable);
}