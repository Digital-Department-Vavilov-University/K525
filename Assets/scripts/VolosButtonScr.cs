using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolosButtonScr : MonoBehaviour
{
    public List<GameObject> Buttons, InfoPanels;
    public Material NotWasReadMtr, WasReadMtr;

    bool IsChosingNow;

    public void ChooseButton(int buttonIndex)
    {
        if(!IsChosingNow)
        {
            for (int i = 0; i < Buttons.Count; i++)
            {
                if(i != buttonIndex)
                {
                    Buttons[i].SetActive(false);
                }

                IsChosingNow = true;
                InfoPanels[buttonIndex].SetActive(true);
            }

            SwitchMaterial(buttonIndex);
        }
        else
        {
            for (int i = 0; i < Buttons.Count; i++)
            {
                Buttons[i].SetActive(true);

                IsChosingNow = false;
                InfoPanels[buttonIndex].SetActive(false);
            }

            SwitchMaterial(buttonIndex);
        }
    }

    private void SwitchMaterial(int buttonIndex)
    {
        if (Buttons[buttonIndex].GetComponent<Renderer>().material == WasReadMtr)
        {
            Buttons[buttonIndex].GetComponent<Renderer>().material = NotWasReadMtr;
        }
        else
        {
            Buttons[buttonIndex].GetComponent<Renderer>().material = WasReadMtr;
        }
    }
}
