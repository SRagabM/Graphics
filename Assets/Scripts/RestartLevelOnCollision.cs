using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartLevelOnCollision : MonoBehaviour
{
    [SerializeField]
    string StrTag;
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == StrTag)
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
