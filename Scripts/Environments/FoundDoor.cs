using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FoundDoor : MonoBehaviour
{
    public float TheDistance;

    public GameObject ActionDisplay;
    public GameObject ActionText;
    
    public GameObject extraCross;
    public AudioSource doorLocked;
    public bool triggeredEntered;
    public string tagString;
    public bool isFound;
   
     public GameObject fadeOut;
    // Update is called once per frame
    void Update()
    {
        TheDistance = PlayerCasting.DistanceFromTarget;
        if((Input.GetButtonDown("Action")) && triggeredEntered == true)
        {
                this.GetComponent<BoxCollider>().enabled = false;

                ActionDisplay.SetActive(false);
                ActionText.SetActive(false);
                
                extraCross.SetActive(false);
                StartCoroutine(DoorReset());
        }
        
    }
    void OnTriggerEnter (Collider enter)
    {
        isFound = true;
        triggeredEntered = true;
        tagString = enter.gameObject.tag;
        Debug.Log(tagString);
        extraCross.SetActive(true);
        ActionDisplay.SetActive(true);
        ActionText.GetComponent<Text>().text = "Open Door";
        ActionText.SetActive(true);
       
        
    }

    void OnTriggerExit(Collider exit)
    {
        isFound = false;
        triggeredEntered = false;
        ActionDisplay.SetActive(false);
        ActionText.SetActive(false);
        extraCross.SetActive(false);
    }

    IEnumerator DoorReset()
    {
        if(GlobalInventory.firstDoorKey == false && triggeredEntered == true){
            doorLocked.Play();
            yield return new WaitForSeconds(1);
            this.GetComponent<BoxCollider>().enabled = true;
        }
        else{
            
            if(isFound == true)
            {
                fadeOut.SetActive(true);
                yield return new WaitForSeconds(3);
                SceneManager.LoadScene(7);
            }
           
        }


    }

        

    
}
