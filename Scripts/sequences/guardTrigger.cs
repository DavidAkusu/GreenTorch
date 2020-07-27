using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class guardTrigger : MonoBehaviour
{
    public GameObject zombie;
    public GameObject zombie1;
    public GameObject zombie2;
    void OnTriggerEnter()
    {
        GetComponent<BoxCollider>().enabled = false;
        
        
        zombie.SetActive(true);
        zombie1.SetActive(true);
        zombie2.SetActive(true);
    }
}
