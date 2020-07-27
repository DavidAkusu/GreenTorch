using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoorCellOpen : MonoBehaviour
{
    public float TheDistance;

    public GameObject ActionDisplay;
    public GameObject ActionText;
    public GameObject theDoor;
    public AudioSource creakSound;
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
            ActionText.SetActive (true);
        }
        if(Input.GetButtonDown("Action"))
        {
            if(TheDistance < 3)
            {
                this.GetComponent<BoxCollider>().enabled =false;
                ActionDisplay.SetActive(false);
                ActionText.SetActive(false);
                theDoor.GetComponent<Animation>().Play("firstDoorOpenAnim");
                creakSound.Play();
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
