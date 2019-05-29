using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarScript : MonoBehaviour
{
    private float lightAmount;

    public GameObject connectorToPlayerScript;
    private PlayerScript playerscript;

    [SerializeField]
    private Image content;

    void Awake()
    {
        //playerscript = connectorToPlayerScript.GetComponent<PlayerScript>();

    }

    // Update is called once per frame
    void Update()
    {
        lightAmount = playerscript.lightIntensity;
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
