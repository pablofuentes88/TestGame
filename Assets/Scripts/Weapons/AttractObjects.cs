using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttractObjects : MonoBehaviour
{
    public float magnetDistance = 0f;
    Vector3 desiredPosition;

    // Start is called before the first frame update
    void Start()
    {
        
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
                hitColliders[i].transform.RotateAround(transform.position, Vector3.up, 200 * Time.deltaTime);
                desiredPosition = (hitColliders[i].transform.position - transform.position).normalized * 1f + transform.position;
                hitColliders[i].transform.position = Vector3.MoveTowards(hitColliders[i].transform.position, desiredPosition, 2 * Time.deltaTime);
                hitColliders[i].GetComponent<Rigidbody>().AddForce(transform.up * 10);
            }
                //Debug.Log(hitColliders[i].name);
        }
    }

}
