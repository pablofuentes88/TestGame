using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunOfLeila : MonoBehaviour
{
    public GameObject bullet;

    public void Shoot()
    {
        Debug.Log("Puumm from GunOfLeila");
        GameObject currentBullet = Instantiate(bullet, transform.position+(transform.right*6), Quaternion.identity);
        Destroy(currentBullet, 5f);
        
    }
}
