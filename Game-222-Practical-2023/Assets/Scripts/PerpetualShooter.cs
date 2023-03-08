using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PerpetualShooter : MonoBehaviour
{
    [SerializeField]
    private GameObject projectiles;

    [SerializeField]
    private float rate = 0.5f;
    [SerializeField]
    private float speed = 1f;
    [SerializeField]
    private float lifeTime = 1f;
    [SerializeField]
    private Vector3 direction= Vector3.forward;

    private void Start()
    {
       StartCoroutine(nameof(Shoot));
    }
    private void OnDisable()
    {
        StopAllCoroutines();
    }
    IEnumerator Shoot()
    {
        Projectile currentProjectile;
        while (true) 
        {
            yield return new WaitForSeconds(rate);
            currentProjectile  = Instantiate(projectiles,transform.position,transform.rotation).GetComponent<Projectile>();
            currentProjectile.SetDirection(direction);
            currentProjectile.SetSpeed(speed);
            currentProjectile.SetLifeTime(lifeTime);
        }
    }
}
