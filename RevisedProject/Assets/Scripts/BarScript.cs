using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarScript : MonoBehaviour
{
    private float lightAmount;

    [SerializeField]
    private Image content;

    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        lightAmount = (PlayerScript.instance.lightIntensity);
        UpdateLightBar();
    }

    private void UpdateLightBar()
    {
        content.fillAmount = (lightAmount)/20;
    }

    private float Map(float value, float inMin, float inMax, float outMin, float outMax)
    {
        return (value - inMin) * (outMax - outMin) / (inMax - inMin);
    }
}
