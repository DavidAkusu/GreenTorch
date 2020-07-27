using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class BacktoMenu : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(Waiting());

    }
    IEnumerator Waiting()
    {
        yield return new WaitForSeconds(12);
        SceneManager.LoadScene(1);
    }
}
