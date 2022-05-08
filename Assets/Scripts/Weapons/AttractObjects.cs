using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttractObjects : MonoBehaviour
{
    [SerializeField] GunOfLeilaTP data;
    private float magnetDistance;
    private float rotateAroundVelocity;
    private float verticalForce;

    private void Start()
    {
        magnetDistance = data.MagnetDistance;
        rotateAroundVelocity = data.RotateAroundVelocity;
        verticalForce = data.VerticalForce;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //Getting all objects that the virtual sphere touch
        Collider[] hitColliders = Physics.OverlapSphere(transform.position, magnetDistance);
        
        for (int i = 0; i < hitColliders.Length; i++)
        {
            if (hitColliders[i].CompareTag("isAttractable"))
            {
                hitColliders[i].transform.RotateAround(transform.position, Vector3.up, rotateAroundVelocity * Time.deltaTime);
                Vector3 desiredPosition = (hitColliders[i].transform.position - transform.position).normalized * 1f + transform.position;
                hitColliders[i].transform.position = Vector3.MoveTowards(hitColliders[i].transform.position, desiredPosition, 2 * Time.deltaTime);
                hitColliders[i].GetComponent<Rigidbody>().AddForce(transform.up * verticalForce);
            }
                //Debug.Log(hitColliders[i].name);
        }
    }

}
