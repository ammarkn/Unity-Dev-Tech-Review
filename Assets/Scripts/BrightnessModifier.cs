using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BrightnessModifier : MonoBehaviour
{

    public Slider brightnessSlider;
    public Slider contrastSlider;
    public Material imageMaterial;

    private Color defaultColor;
    private float defaultContrast;
    private bool isInverted = false;

    // Start is called before the first frame update
    void Start()
    {
        defaultColor = imageMaterial.color;
        defaultContrast = imageMaterial.GetFloat("_Contrast");

        brightnessSlider.onValueChanged.AddListener(changeBrightness);
        contrastSlider.onValueChanged.AddListener(changeContrast);
    }

    void changeBrightness(float value) {
        imageMaterial.color = new Color(1 + value, 1 + value, 1 + value, 1);
    }

    void changeContrast(float value) {
        imageMaterial.SetFloat("_Contrast", value);
    }

    public void ToggleInvertColors() {
        isInverted = !isInverted;
        UpdateColors();
    }

    public void UpdateColors() {
        if(isInverted) {
            imageMaterial.SetFloat("_Invert", 1);
        }
        else {
            imageMaterial.SetFloat("_Invert", 0);
        }
    }

    void OnDisable() {
        imageMaterial.color = defaultColor;
        imageMaterial.SetFloat("_Contrast", defaultContrast);
        imageMaterial.SetFloat("_Invert", 0);
        brightnessSlider.value = 0;
        contrastSlider.value = defaultContrast;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
