using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class idleZombieAI : MonoBehaviour
{
    public GameObject thePlayer;
    public GameObject theEnemy;
    public GameObject theFlash;
    public float enemySpeed = 0.01f;
    public bool attackTrigger = false;
    public bool isAttacking = false;
    public AudioSource hurtSound1;
    public AudioSource hurtSound2;

    public AudioSource hurtSound3;
    public int hurtRand;


    // Update is called once per frame
    void Update()
    {
        transform.LookAt(thePlayer.transform);
        if(attackTrigger == false)
        {
            enemySpeed = 0.000f;
            theEnemy.GetComponent<Animation>().Play("idle");
            transform.position = Vector3.MoveTowards(transform.position, thePlayer.transform.position, enemySpeed);
        }
        if(attackTrigger == true && isAttacking == false)
        { 
            enemySpeed = 0;
            theEnemy.GetComponent<Animation>().Play("zombieAttack");
            StartCoroutine(inflictDamage());
        }
    }

    IEnumerator inflictDamage()
    {
        isAttacking = true;
        hurtRand = Random.Range(1,4);
        if(hurtRand == 1)
            hurtSound1.Play();
        if(hurtRand == 2)
            hurtSound2.Play();
        if(hurtRand == 3)
            hurtSound3.Play();

        theFlash.SetActive(true);
        yield return new WaitForSeconds(0.2f);
        theFlash.SetActive(false);
        yield return new WaitForSeconds(0.9f);
        GlobalHealth.currentHealth -= 4;
       
        yield return new WaitForSeconds(0.01f);
        isAttacking = false;
    }

    void OnTriggerEnter()
    {
        attackTrigger =true;
    }
    void OnTriggerExit()
    {
        attackTrigger = false;
    }
}
