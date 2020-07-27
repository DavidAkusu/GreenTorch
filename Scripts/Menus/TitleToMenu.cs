using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleToMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(toMenu());
    }

   IEnumerator toMenu()
   {
       yield return new WaitForSeconds(10);
       SceneManager.LoadScene(1);
   }
}
