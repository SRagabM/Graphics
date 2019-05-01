using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class EndFlag : MonoBehaviour
{
    public GameManager gameManager;

    public void OnTriggerEnter(Collider other)
    {
        gameManager.CompleteLevel();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
