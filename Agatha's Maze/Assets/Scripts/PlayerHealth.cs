using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public string gameOverScene;
   public void Kill()
    {
        Destroy(gameObject);

        SceneManager.LoadScene(gameOverScene);
        
    }



}
