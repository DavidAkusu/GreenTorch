using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class idleZombieDeath : MonoBehaviour
{
    public int EnemyHealth = 20;
    public GameObject TheEnemy;
    public int statusCheck;
    public AudioSource scaryMusic;
    // Update is called once per frame
    void Update()
    {
        if(EnemyHealth <= 0 && statusCheck== 0)
        {
            
            this.GetComponent<idleZombieAI>().enabled = false;
            this.GetComponent<BoxCollider>().enabled = false;
            TheEnemy.GetComponent<Animation>().Stop("idle");
            TheEnemy.GetComponent<Animation>().Play("fallingBack");
            statusCheck = 2;
            scaryMusic.Play();

        }

    }

    void DamageZombie( int DamageAmount)
    {
        EnemyHealth -= DamageAmount;
    }
}
