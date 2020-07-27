using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.UI;

public class AOpening : MonoBehaviour
{
    public GameObject ThePlayer;
    public GameObject FadeScreenIn;
    public GameObject Textbox;
    public AudioSource line01;
 


    // Start is called before the first frame update
    void Start()
    {
        ThePlayer.GetComponent<FirstPersonController>().enabled = false;
        StartCoroutine(ScenePlayer());
        
    }
    IEnumerator ScenePlayer()
    {

        yield return new WaitForSeconds(1.5f);
        FadeScreenIn.SetActive(false);
        Textbox.GetComponent<Text>().text = "Where am I?...";
        line01.Play();
        yield return new WaitForSeconds (5);
        Textbox.GetComponent<Text> ().text = "";
        ThePlayer.GetComponent<FirstPersonController>().enabled = true;

    }

    
}
