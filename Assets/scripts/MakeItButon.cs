using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MakeItButon : MonoBehaviour
{
    public UnityEvent UnityEvent = new UnityEvent();
    public GameObject InfoPanel;
    public bool IsInfoPanelButton;

    public Material NotWasReadMtr, WasReadMtr;
    public string SafeMyStateKey;

    private void Start()
    {
        if(IsInfoPanelButton)
        {
            PlayerPrefs.SetInt(SafeMyStateKey, 0);
            GetComponent<Renderer>().material = PlayerPrefs.GetInt(SafeMyStateKey) == 0 ? NotWasReadMtr : WasReadMtr;
        }
    }

    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(ray, out hit) && hit.collider.gameObject == gameObject)
            {
                UnityEvent.Invoke();
            }
        }
    }

    public void SetReadState(bool wasRead)
    {
        GetComponent<Renderer>().material = wasRead ? WasReadMtr : NotWasReadMtr;
        PlayerPrefs.SetInt(SafeMyStateKey, 1);
    }
}
