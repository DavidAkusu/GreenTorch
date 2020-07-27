using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthMonitor : MonoBehaviour
{
    public GameObject Health01;
   public GameObject Health02;
   public GameObject Health03;
   public GameObject Health04;
   public GameObject Health05;
   public int CurrentHealth;
   void Update()
   {
       CurrentHealth = GlobalHealth.currentHealth;
       if(CurrentHealth == 16){
               Health01.SetActive(false);
        }
           

       if(CurrentHealth == 12){
           
        Health02.SetActive(false);
       }
           

       if(CurrentHealth == 8){
           
            Health03.SetActive(false);
           
       }

       if(CurrentHealth == 4){
          
            Health04.SetActive(false);
           
       }

       if(CurrentHealth <= 0){
         
         Health05.SetActive(false);
          
           
       }
   }
}
