using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CHordTrigger : MonoBehaviour
{
    public GameObject zombie;
    public GameObject zombie1;
    public GameObject zombie2;
    public GameObject zombie3;

    void OnTriggerEnter()
    {
        GetComponent<BoxCollider>().enabled = false;
        
        
        zombie.SetActive(true);
        zombie1.SetActive(true);
        zombie2.SetActive(true);
        zombie3.SetActive(true);

    }
}
