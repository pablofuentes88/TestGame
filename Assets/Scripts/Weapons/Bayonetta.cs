using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bayonetta : MonoBehaviour
{
    public GameObject bullet;
    public GameObject explosionEffect;
    public Material bulletMaterial;

    float radius = 5.0f;
    float power = 500.0f;


    public void Shoot()
    {
        Debug.Log("Puumm from Bayonetta");
        GameObject currentBullet = Instantiate(bullet, transform.position, Quaternion.identity);
        currentBullet.GetComponent<Renderer>().material = bulletMaterial;
        currentBullet.GetComponent<Rigidbody>().AddForce(transform.right * 500);
        StartCoroutine(Explosion(currentBullet));
    }

    IEnumerator Explosion(GameObject bullet)
    {
        yield return new WaitForSeconds(3);
        GameObject currentExplosionEffect = Instantiate(explosionEffect, bullet.transform.position, Quaternion.identity);
        Destroy(bullet);
        Vector3 explosionPos = currentExplosionEffect.transform.position;
        Collider[] colliders = Physics.OverlapSphere(explosionPos, radius);

        foreach (Collider hit in colliders)
        {
            if (hit.CompareTag("isAttractable"))
            {
                hit.GetComponent<Rigidbody>().AddExplosionForce(power, explosionPos, radius, 3.0f);
            }
        }
    }
}
