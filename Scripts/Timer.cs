using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
   public GameObject textDisplay;
   public int secondsLeft = 59; 
   public int minutesLeft = 0;
   public bool takingAway = false;
   void Start()
   {
       textDisplay.GetComponent<Text>().text = "0"+minutesLeft +":" + secondsLeft;
   }

    void Update()
    {
        if(minutesLeft < 0)
        {
            SceneManager.LoadScene(5);
        }
        if(takingAway == false && secondsLeft > 0)
        {
            StartCoroutine(TimerTake());
        }
    }
   IEnumerator TimerTake()
   {
       takingAway = true;
       yield return new WaitForSeconds(1);
       secondsLeft -= 1;
       if(secondsLeft < 10) {
        textDisplay.GetComponent<Text>().text = "0" + minutesLeft +":0" + secondsLeft;
       }
       else 
       {
            textDisplay.GetComponent<Text>().text = "0" + minutesLeft +":" + secondsLeft;
       }
       if(secondsLeft == 0)
       {
           minutesLeft -= 1;
           secondsLeft = 60;
       }
       takingAway = false;
   }
    

}
