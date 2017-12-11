using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour {

    public static MenuManager instance;

    [SerializeField]
    GameObject current;
    GameObject main;
    [SerializeField]
    List<ButtonController> buttons;

    public void Awake()
    {
        if (!instance)
            instance = this;
        else
            Destroy(gameObject);
        DontDestroyOnLoad(gameObject);
        current = GameObject.Find("MainMenu");
        main = current;
    }

    public void ActivateCanvas(GameObject canvas)
    {
        current.SetActive(false);
        current = canvas;
        current.SetActive(true);
    }
}
