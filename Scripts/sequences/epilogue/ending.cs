using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ending : MonoBehaviour
{
    public AudioSource scaryMusic;
    public AudioSource maleScream;
    public AudioSource womanScream;
    public AudioSource clicker;



    public AudioSource gameMusic;

    public GameObject allBlack;
    public GameObject zombie;
    public GameObject zombie01;

    public GameObject zombie02;
    public GameObject zombie03;

    public GameObject fadeIn;
    void Start()
    {
        fadeIn.GetComponent<Animation>().Play("FadeScreenIn");
        gameMusic.Stop();
        zombie.SetActive(false);
        zombie01.SetActive(false);
        zombie02.SetActive(false);
        zombie03.SetActive(false);
        StartCoroutine(cutscene());
    }

    IEnumerator cutscene()
    {
        scaryMusic.Play();
        yield return new WaitForSeconds(18);
        zombie.SetActive(true);
        zombie01.SetActive(true);
        zombie02.SetActive(true);
        zombie03.SetActive(true);
        yield return new WaitForSeconds(2);

        maleScream.Play();
        yield return new WaitForSeconds(3);
        womanScream.Play();
        yield return new WaitForSeconds(3);
        clicker.Play();
        yield return new WaitForSeconds(31);
        allBlack.SetActive(true);
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene(6);
        
    }
}
