using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class buttons_menu : MonoBehaviour
{
    public GameObject[] Panels;

    public void ChangePanel(int panelNum)
    {
        for(int i = 0; i < Panels.Length; i++)
        {
            Panels[i].SetActive(false);
        }

        Panels[panelNum].SetActive(true);
    }

    public void ChangeScene(int SceneNum)
    {
        SceneManager.LoadScene(SceneNum);
    }
}
