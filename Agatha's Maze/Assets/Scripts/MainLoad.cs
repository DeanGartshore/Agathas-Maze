using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainLoad : MonoBehaviour
{
    public void LoadGame()
    {
        SceneManager.LoadScene("StartMenu");
    }
}
