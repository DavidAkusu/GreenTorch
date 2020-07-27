using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class keyPickup : MonoBehaviour
{
    public float TheDistance;

    public GameObject ActionDisplay;
    public GameObject ActionText;
    
    public GameObject extraCross;
    public GameObject theKey;
    public bool triggeredEntered = false;
    public GameObject trig;
   
    // Update is called once per frame
    void Update()
    {
        TheDistance = PlayerCasting.DistanceFromTarget;
        if((Input.GetButtonDown("Action")) && triggeredEntered == true)
        {
                this.GetComponent<BoxCollider>().enabled = false;
                theKey.SetActive(false);
                GlobalInventory.firstDoorKey = true;

                ActionDisplay.SetActive(false);
                ActionText.SetActive(false);
                
                extraCross.SetActive(false);
                trig.SetActive(false);
        }
        
    }
    void OnTriggerEnter(Collider other)
    {
      
            triggeredEntered = true;
            extraCross.SetActive(true);
            ActionDisplay.SetActive(true);
            ActionText.GetComponent<Text>().text = "Pick up key";
            ActionText.SetActive(true);
        
        
    }

    void OnTriggerExit(Collider exit)
    {
        //ActionDisplay.SetActive(false);
        ActionText.GetComponent<Text>().text = "";
         ActionText.SetActive(true);
        //extraCross.SetActive(false);
    }


}
