using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SaveButton : MonoBehaviour
{
    public string MenuSceneName;

    [SerializeField]
    private GameObject MenuBtn;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
        SceneManager.LoadScene("_menu");
    }

    public GameObject EscBtn;
    private void Start()
    {
        EscBtn = GameObject.Find("EscBtn");
    }

    private void Update()
    {
        if(SceneManager.GetActiveScene().name == MenuSceneName)
        {
            MenuBtn.SetActive(false);
            EscBtn.SetActive(true);
        }
        else
        {
            MenuBtn.SetActive(true);
            EscBtn.SetActive(false);
        }

        
}
}

