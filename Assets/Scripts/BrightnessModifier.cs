using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BrightnessModifier : MonoBehaviour
{

    public Slider brightnessSlider;
    public Slider contrastSlider;
    public Material imageMaterial;

    private Color imageColor;

    // Start is called before the first frame update
    void Start()
    {
        imageColor = imageMaterial.color;
        brightnessSlider.onValueChanged.AddListener(changeBrightness);
        contrastSlider.onValueChanged.AddListener(changeContrast);
    }

    void changeBrightness(float value) {
        imageMaterial.color = imageColor + new Color(value, value, value, 0);
    }

    void changeContrast(float value) {
        // imageMaterial.SrtFloat("_Contrast", value);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
