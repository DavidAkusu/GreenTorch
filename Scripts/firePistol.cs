using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class firePistol : MonoBehaviour
{
    public GameObject theGun;
    public GameObject muzzleFlash;
    public AudioSource gunFire;
    public bool IsFiring = false;
    public float TargetDistance;
    public int DamageAmount = 5;


    void Update()
    {
        if (Input.GetButtonDown("Fire1") && globalAmmo.ammoCount>= 1)
        {
            if(IsFiring == false)
            {
                globalAmmo.ammoCount -= 1;
                StartCoroutine(FiringPistol());
            }
        }

    }
    IEnumerator FiringPistol()
    {
        RaycastHit Shot;
        IsFiring = true;
        if(Physics.Raycast (transform.position, transform.TransformDirection(Vector3.forward), out Shot))
        {
            TargetDistance = Shot.distance;
            Shot.transform.SendMessage("DamageZombie", DamageAmount, SendMessageOptions.DontRequireReceiver);
        }
        theGun.GetComponent<Animation>().Play("pistolShot");
        muzzleFlash.SetActive(true);
        muzzleFlash.GetComponent<Animation>().Play("muzzleAnim");
        
        gunFire.Play();
        yield return new WaitForSeconds(0.5f);
        IsFiring = false;
    }
}
