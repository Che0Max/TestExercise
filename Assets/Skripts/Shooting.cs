using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPref;

    public float bulletForce;

    private float nextTime = 0.0f;
    private float timeRate = 0.1f;

    void Update()
    {
        while(Time.time > nextTime)
        {
            nextTime = Time.time + timeRate;
            Shoot();
        }
    }

    void Shoot()
    { 
        GameObject bullet = Instantiate(bulletPref, firePoint.position, firePoint.rotation);
        Rigidbody rb = bullet.GetComponent<Rigidbody>();
        rb.AddForce(firePoint.forward * bulletForce, ForceMode.Impulse);
    }
}
