using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickUpGun : MonoBehaviour
{
    public float TheDistance;

    public GameObject ActionDisplay;
    public GameObject ActionText;
    public GameObject fakePistol;
    public GameObject realPistol;
    public GameObject jumpTrigger;
    public GameObject extraCross;
    // Update is called once per frame
    void Update()
    {
        TheDistance = PlayerCasting.DistanceFromTarget;
        
    }
    void OnMouseOver ()
    {
        if(TheDistance < 3)
        {
            extraCross.SetActive(true);
            ActionDisplay.SetActive (true);
            ActionText.GetComponent<Text>().text = "Pick up Weapon.";
            ActionText.SetActive(true);
        }
        if(Input.GetButtonDown("Action"))
        {
            if(TheDistance < 3)
            {
                this.GetComponent<BoxCollider>().enabled =false;
                ActionDisplay.SetActive(true);
                ActionText.SetActive(true);
                fakePistol.SetActive(false);
                realPistol.SetActive(true);
                extraCross.SetActive(false);
                jumpTrigger.SetActive(true);
            }
        }
    }

    void OnMouseExit()
    {
        ActionDisplay.SetActive(false);
        ActionText.SetActive(false);
        extraCross.SetActive(false);
    }
}
