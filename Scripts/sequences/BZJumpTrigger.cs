using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BZJumpTrigger : MonoBehaviour
{
    public AudioSource doorBang;
    public AudioSource doorJumpMusic;
    public GameObject zombie;
    public GameObject zombie1;
    public GameObject fastZombie;
    public GameObject theDoor;
    public AudioSource scaryMusic;
    
    void OnTriggerEnter()
    {
        GetComponent<BoxCollider>().enabled = false;
        theDoor.GetComponent<Animation>().Play("jumpDoorAnim");
        doorBang.Play();
        zombie.SetActive(true);
        zombie1.SetActive(true);
        fastZombie.SetActive(true);
        StartCoroutine(PlayJumpMusic());

    }
    IEnumerator PlayJumpMusic()
    {
        yield return new WaitForSeconds(0.4f);
        scaryMusic.Pause();
        doorJumpMusic.Play();
    }
}
