using UnityEngine;

public class Demogorgun : MonoBehaviour
{
    public GameObject bullet;

    //Shoot bullet when player taked the weapon
    public void Shoot ()
    {
        GameObject currentBullet = Instantiate(bullet, transform.position, Quaternion.identity);
        currentBullet.GetComponent<Rigidbody>().AddForce(transform.right * 500);
        currentBullet.GetComponent<Rigidbody>().AddForce(transform.up * 500);
    }
}
