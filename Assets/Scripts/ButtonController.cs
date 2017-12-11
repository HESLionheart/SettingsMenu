using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour {

    [SerializeField]
    GameObject canvas;

    public void Awake()
    {
        if(canvas==null)
            canvas= GameObject.Find("MainMenu");
    }

    public void LoadCanvas()
    {
        MenuManager.instance.ActivateCanvas(canvas);
    }
}
