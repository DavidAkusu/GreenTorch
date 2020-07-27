using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieDeath : MonoBehaviour
{
    public int EnemyHealth = 20;
    public GameObject TheEnemy;
    public int statusCheck;
    public AudioSource JumpscareMusic;
    public AudioSource scaryMusic;
    // Update is called once per frame
    void Update()
    {
        if(EnemyHealth <= 0 && statusCheck== 0)
        {
            statusCheck = 2;
            this.GetComponent<ZombieAI>().enabled = false;
            this.GetComponent<BoxCollider>().enabled = false;
            TheEnemy.GetComponent<Animation>().Stop("walk");
            TheEnemy.GetComponent<Animation>().Play("fallingBack");
            JumpscareMusic.Stop();
            scaryMusic.Play();

        }

    }

    void DamageZombie( int DamageAmount)
    {
        EnemyHealth -= DamageAmount;
    }
}
