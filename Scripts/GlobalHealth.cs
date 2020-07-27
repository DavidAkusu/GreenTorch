using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GlobalHealth : MonoBehaviour
{
    public static int currentHealth = 20;
    public GameObject obj1;
   public GameObject obj2;
   public GameObject obj3;
   public GameObject obj4;
   public GameObject obj5;
   public GameObject thePlayer;
    public int internalHealth;

    void Start()
    {
        currentHealth = 20;
        obj1.SetActive(true);
        obj2.SetActive(true);
        obj3.SetActive(true);
        obj4.SetActive(true);
        obj5.SetActive(true);
    }
    // Update is called once per frame
    void Update()
    {
        internalHealth = currentHealth;
        if(internalHealth <= 0)
        {
           obj1.SetActive(false);
           obj2.SetActive(false);
           obj3.SetActive(false);
           obj4.SetActive(false);
           obj5.SetActive(false);

          
           thePlayer.GetComponent<CharacterController>().enabled = false; 
           StartCoroutine(Waiting());
        }
    }
    IEnumerator Waiting()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(5);

    }
}
