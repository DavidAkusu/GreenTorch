using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VaseBreak : MonoBehaviour
{
    public GameObject fakeVase;
    public GameObject brokenVase;
    public GameObject sphereObj;
    public AudioSource breaking;
    public GameObject keyObject;
    public GameObject keyTrigger;
    void DamageZombie( int DamageAmount)
    {
        StartCoroutine(BreakVase());

    }
    IEnumerator BreakVase()
    {
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
        breaking.Play();
        keyObject.SetActive(true);
        fakeVase.SetActive(false);
        keyTrigger.SetActive(true);
        brokenVase.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        sphereObj.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        sphereObj.SetActive(false);


    }
}
