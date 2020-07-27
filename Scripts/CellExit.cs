using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CellExit : MonoBehaviour
{
    public float TheDistance;

    public GameObject ActionDisplay;
    public GameObject ActionText;
   public GameObject extraCross;
    //public AudioSource creakSound;
    public GameObject fadeOut;
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
            ActionText.GetComponent<Text>().text = "Open the door";
            ActionText.SetActive (true);
        }
        if(Input.GetButtonDown("Action"))
        {
            if(TheDistance < 3)
            {
                
                this.GetComponent<BoxCollider>().enabled =false;
                ActionDisplay.SetActive(false);
                ActionText.SetActive(false);
                fadeOut.SetActive(true);
                globalAmmo.ammoCount = 0;
                StartCoroutine(Fading());
                //theDoor.GetComponent<Animation>().Play("firstDoorOpenAnim");
                //creakSound.Play();
            }
        }
    }

    void OnMouseExit()
    {
        extraCross.SetActive(false);
        ActionDisplay.SetActive(false);
        ActionText.SetActive(false);
        
    }
    IEnumerator Fading()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(4);
    }
}
