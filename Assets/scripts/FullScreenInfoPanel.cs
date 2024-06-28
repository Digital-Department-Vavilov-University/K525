using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FullScreenInfoPanel : MonoBehaviour
{
    [SerializeField]
    private Image InfoPanel;

    public void SwitchInfoPanelActive()
    {
        gameObject.active = InfoPanel.IsActive() ? false : true; 
    }

    public void OpenInfoPanel(Sprite newSprite)
    {
        InfoPanel.sprite = newSprite;
    }
}
