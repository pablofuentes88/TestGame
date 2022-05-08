using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wapons : MonoBehaviour
{
    GameObject weaponHand;
    bool isDropingWeapon = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1") && weaponHand != null)
            weaponHand.SendMessage("Shoot");

        if (Input.GetKeyDown(KeyCode.E) && weaponHand != null && !isDropingWeapon)       
            DropWeapon();
        
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (weaponHand != null) return;

        weaponHand = other.gameObject;
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

    void DropWeapon()
    {
        isDropingWeapon = true;
        weaponHand.transform.SetParent(null);
        StartCoroutine(DropingWeapon());
        
    }

    IEnumerator DropingWeapon()
    {
        yield return new WaitForSeconds(2);
        weaponHand.GetComponent<AutoRotate>().enabled = true;
        weaponHand.GetComponent<BoxCollider>().enabled = true;
        weaponHand = null;
        isDropingWeapon = false;
    }
}
