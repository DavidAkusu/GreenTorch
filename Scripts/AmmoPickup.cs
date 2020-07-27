using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoPickup : MonoBehaviour
{
    public GameObject theAmmo;
    public GameObject ammoDisplayPanel;
    public AudioSource ammoPickup;
    void OnTriggerEnter(Collider other)
    {

        ammoPickup.Play();
        theAmmo.SetActive(false);
        if(globalAmmo.ammoCount < 10)
        {
            globalAmmo.ammoCount = globalAmmo.ammoCount + 10;
        }
        ammoDisplayPanel.SetActive(true);

    }
}
