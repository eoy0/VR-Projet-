using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pistol : MonoBehaviour
{
    [SerializeField]
    Transform firepoint;

    [SerializeField]
    float fireForce = 1;

    public void Shoot()
    {
        RaycastHit hitInfo;

       bool hit = Physics.Raycast(firepoint.position, firepoint.forward, out hitInfo, 500);

        if (hit)
        {
            hitInfo.collider.transform.GetComponent<Rigidbody>().AddForceAtPosition(fireForce * firepoint.forward, hitInfo.point, ForceMode.Impulse);
        }
    }
}
