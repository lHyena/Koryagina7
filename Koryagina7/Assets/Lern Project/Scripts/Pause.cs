using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    public GameObject pausePanel;
    [SerializeField] private Button _quitGameButton;

    private void Awake()
    {
        _quitGameButton.onClick.AddListener(() => { Application.Quit(); });
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            pausePanel.SetActive(true);
            Time.timeScale = 0;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            pausePanel.SetActive(false);
            Time.timeScale = 1;
        }
    }


}
