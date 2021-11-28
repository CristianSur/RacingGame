using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bullet;

    public void Start()
    {
        InvokeRepeating("Shoot", 1f, 0.1f);
    }
    void Update()
    {
        //if (Input.GetButtonDown("Fire1"))
       // {
          //  shoot();
        //}
    }

    void Shoot()
    {
        Instantiate(bullet, firePoint.position, firePoint.rotation);
    }
}

