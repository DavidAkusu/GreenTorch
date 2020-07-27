using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuFunction : MonoBehaviour
{
    public GameObject fadeOut;
    public AudioSource buttonClick;

    public void NewGameButton()
    {
        StartCoroutine(newGameStart());
    }
    public void CreditsButton()
    {
        StartCoroutine(Credits());
    }
    public void quitGame()
    {
#if UNITY_EDITOR
    UnityEditor.EditorApplication.isPlaying = false;
#else
    Application.Quit();
#endif
    }
    IEnumerator Credits()
    {
        fadeOut.SetActive(true);
        buttonClick.Play();
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(6);
    }
    IEnumerator newGameStart()
    {
        fadeOut.SetActive(true);
        buttonClick.Play();
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(2);

    }
}
