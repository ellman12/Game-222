using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireProjectile : MonoBehaviour
{
    [SerializeField]
    private GameObject projectile;

    private void OnEnable()
    {
        PlayerAbilities.PrimaryFire += PrimaryFire;
    }
    private void OnDisable()
    {
        PlayerAbilities.PrimaryFire -= PrimaryFire;
    }
    private void PrimaryFire()
    {
        Instantiate(projectile,transform.position,Quaternion.identity);
    }
}
