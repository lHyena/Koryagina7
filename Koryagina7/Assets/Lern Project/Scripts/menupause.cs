using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class menupause : MonoBehaviour
{
    [SerializeField] private Button _menuButton;
    [SerializeField] private Button _quitGameButton;

    public Slider _sl;

    private void Awake()
    {
        _quitGameButton.onClick.AddListener( () => { Application.Quit(); });
        _menuButton.onClick.AddListener(MenuPanel);

        _sl.onValueChanged.AddListener((value) =>
        {
            Debug.Log(value);
        });
    }

    public void MenuPanel()
    {
        SceneManager.LoadScene(0);
    }
}
