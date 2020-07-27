using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class IntroSequencing : MonoBehaviour
{
   public GameObject Textbox;
   public GameObject dateDisplay;
   public GameObject placeDisplay;
   public AudioSource iRan;
   public AudioSource FindIt;

   public AudioSource powerObj;
   public AudioSource FoundMe
   ;
   public AudioSource MuchTime;
   public AudioSource killYou;
   public AudioSource GreenTorch;
   public AudioSource thudSound;
   public GameObject allBlack;

    void Start()
    {
        StartCoroutine(Begin());
    }
   IEnumerator Begin()
   {
       yield return new WaitForSeconds(4);
       placeDisplay.SetActive(true);
       yield return new WaitForSeconds(2);
       dateDisplay.SetActive(true);
       yield return new WaitForSeconds(4);
       placeDisplay.SetActive(false);
       dateDisplay.SetActive(false);
       yield return new WaitForSeconds(1);
       Textbox.GetComponent<Text>().text = "I ran as fast as I could...But they were many...";
       iRan.Play();
       yield return new WaitForSeconds(10);
       Textbox.GetComponent<Text>().text = "";
       yield return new WaitForSeconds(2);
       Textbox.GetComponent<Text>().text = "They were after the Green Torch";
       GreenTorch.Play();
       yield return new WaitForSeconds(5);
       Textbox.GetComponent<Text>().text = "";
       yield return new WaitForSeconds(1);
       powerObj.Play();
       Textbox.GetComponent<Text>().text = "A powerful object that connects my world to theirs";
       yield return new WaitForSeconds(8);
       Textbox.GetComponent<Text>().text = "";
       yield return new WaitForSeconds(8);
       MuchTime.Play();
       Textbox.GetComponent<Text>().text = "I don't have much time";
       yield return new WaitForSeconds(5);
       Textbox.GetComponent<Text>().text = "";
       yield return new WaitForSeconds(3);
       FoundMe.Play();
       Textbox.GetComponent<Text>().text = "They found me...";
       yield return new WaitForSeconds(3);
       Textbox.GetComponent<Text>().text = "";
       yield return new WaitForSeconds(15);
       FindIt.Play();
       Textbox.GetComponent<Text>().text = "If I don't find it...they will kill me...and then...";
       yield return new WaitForSeconds(8);
       Textbox.GetComponent<Text>().text = "";
       yield return new WaitForSeconds(3);
       killYou.Play();
       yield return new WaitForSeconds(1);
       Textbox.GetComponent<Text>().text = "They'll kill you...";
       yield return new WaitForSeconds(4);
       Textbox.GetComponent<Text>().text = "";
       yield return new WaitForSeconds(13);
       allBlack.SetActive(true);
       thudSound.Play();
       yield return new WaitForSeconds(3);
       SceneManager.LoadScene(3);





       
       








       
















       
       
   } 
}
