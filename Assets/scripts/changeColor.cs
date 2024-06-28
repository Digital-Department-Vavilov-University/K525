using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeColor : MonoBehaviour
{
    public GameObject ChangeColour1;

    void Start()
    {
        ChangeColour1.SetActive(false);
    }
    // Start is called before the first frame update
    void OnMouseEnter()
    {
        GetComponent<Renderer>().material.color = new Color(0, 255, 0, 0.01f);
        ChangeColour1.SetActive(true);
    }

    // Update is called once per frame
    void OnMouseExit()
    {
        GetComponent<Renderer>().material.color = new Color(255, 255, 255, 0);
        ChangeColour1.SetActive(false);
    }
}
