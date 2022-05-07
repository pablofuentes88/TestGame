using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wapons : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        TakeWeapon(other.gameObject);
        Debug.Log("Tomar arma" + other.name);
    }

    private void TakeWeapon(GameObject weapon)
    {
        GameObject weaponPosition = GameObject.Find("WeaponPosition");
        weapon.GetComponent<AutoRotate>().enabled = false;
        weapon.GetComponent<BoxCollider>().enabled = false;
        weapon.transform.SetParent(weaponPosition.transform);
        weapon.transform.position = weaponPosition.transform.position;
        weapon.transform.rotation = weaponPosition.transform.rotation;
    }
}
