using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonAction : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> InfoPanels;

    public void SetInfoPanelsActive(bool active)
    {
        for(int i = 0; i < InfoPanels.Count; i++)
        {
            InfoPanels[i].SetActive(active);
        }
    }

    public void ChangeScene(string SceneName)
    {
        SceneManager.LoadScene(SceneName);
    }
    public void ChangeScene(int SceneNum)
    {
        SceneManager.LoadScene(SceneNum);
    }
}