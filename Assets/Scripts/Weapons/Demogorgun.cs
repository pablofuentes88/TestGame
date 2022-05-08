using UnityEngine;

public class Demogorgun : MonoBehaviour
{
    [SerializeField] DemogorgunTP data;
    public GameObject bullet;
    private float frontForce;
    private float upForce;

    private void Start()
    {
        frontForce = data.FrontForce;
        upForce = data.UpForce;
    }

    //Shoot bullet when player taked the weapon
    public void Shoot ()
    {
        GameObject currentBullet = Instantiate(bullet, transform.position, Quaternion.identity);
        currentBullet.GetComponent<Rigidbody>().AddForce(transform.right * frontForce);
        currentBullet.GetComponent<Rigidbody>().AddForce(transform.up * upForce);
    }
}
