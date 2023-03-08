using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField]
    private float lifeTime, speed;
    [SerializeField]
    private Vector3 direction;

    private float currentLifeTime;
    // Update is called once per frame
    void Update()
    {
        if(currentLifeTime >= lifeTime) 
        {
            Destroy(gameObject);
        }
        currentLifeTime += Time.deltaTime;
        transform.localPosition += direction * Time.deltaTime * speed;
    }
    public void SetDirection(Vector3 velocity)
    {
        direction= velocity;
    }
    public void SetSpeed(float newSpeed)
    {
        speed= newSpeed;
    }
    public void SetLifeTime(float newLifeTime)
    {
        lifeTime = newLifeTime;
    }
}
