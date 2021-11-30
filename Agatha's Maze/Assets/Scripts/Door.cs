using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{
    public string levelToLoad;
    private void OnTriggerEnter(Collider otherCollider)
    {
        Debug.Log("Object hit door!");

        if (otherCollider.tag == "Player")
        {
            SceneManager.LoadScene(levelToLoad);
        }
       


    }
}
