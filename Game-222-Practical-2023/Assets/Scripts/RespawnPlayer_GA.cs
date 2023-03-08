using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using System;

public class RespawnPlayer_GA : GameAction
{
    [SerializeField]
    private PlayerAbilities playerAbilities;
    [SerializeField]
    private PlayerMovement pMovement;
    [SerializeField]
    private MeshRenderer pRenderer;
    [SerializeField]
    private HealthSystem healthSystem;
    private Vector3 origPos;

    public static Action ResetScore = delegate { };

    private void Start()
    {
       origPos= transform.position;
    }
    public override void Action()
    {
        ResetScore();
        healthSystem.enabled = false;
        playerAbilities.enabled = true;
        pMovement.enabled = true;
        pRenderer.enabled = true;
        transform.position = origPos;        
        healthSystem.ResetHealth();    
        StartCoroutine(nameof(EnableHealthSystem));
    }
    IEnumerator EnableHealthSystem()
    {
        yield return new WaitForSeconds(1);
        healthSystem.enabled = true;
    }
}
