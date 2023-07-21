using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
 
    public GameObject bullet;
    public Transform bulletPoint;

    public void Shoot()
    {
        Rigidbody rb = Instantiate(bullet, bulletPoint.position, Quaternion.identity).GetComponent<Rigidbody>();
        rb.AddForce(transform.forward * 30f, ForceMode.Impulse);
        
    }
}
