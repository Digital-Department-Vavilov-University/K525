using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadScenes : MonoBehaviour
{
    public void ChangeScene(string sceneName) 
    {
        SceneManager.LoadScene(sceneName); 
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
