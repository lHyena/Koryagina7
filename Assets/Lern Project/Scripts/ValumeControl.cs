using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;


public class ValumeControl : MonoBehaviour
{

    public string volumeParameter = "MasterVolume";
    public AudioMixer mixer;
    public Slider slider;

    private const float _multipluer = 20f;
    
    private void Awake()
    {
        slider.onValueChanged.AddListener(HandleSliderValueChanged);
    }

    private void HandleSliderValueChanged(float value)
    {
        var volumeValue = Mathf.Log10(value) * _multipluer;
        mixer.SetFloat(volumeParameter, volumeValue);
    }
    
    void Start()
    {
        
    }

   
}
