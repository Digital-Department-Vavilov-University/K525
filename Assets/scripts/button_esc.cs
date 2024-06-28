using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class button_esc : MonoBehaviour
{
    public void Change()
    {
        // Toggle fullscreen
        Screen.fullScreen = !Screen.fullScreen;
    }
}