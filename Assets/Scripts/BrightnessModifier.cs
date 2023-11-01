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
    private float defaultContrast = 1.0f;
    private bool isInverted = false;

    // Start is called before the first frame update
    void Start()
    {
        // Sets the default values of the sliders at the start
        defaultColor = imageMaterial.color;
        brightnessSlider.value = 0;
        contrastSlider.value = defaultContrast;
        imageMaterial.color = defaultColor;
        imageMaterial.SetFloat("_Contrast", defaultContrast);
        imageMaterial.SetFloat("_Invert", 0);

        // Adds listener to both sliders to modify the respective shader values
        brightnessSlider.onValueChanged.AddListener(ChangeBrightness);
        contrastSlider.onValueChanged.AddListener(ChangeContrast);
    }

    // Adjusts the brightness of the image material
    void ChangeBrightness(float value) {
        imageMaterial.color = new Color(1 + value, 1 + value, 1 + value, 1);
    }

    void ChangeContrast(float value) {
        // Modifies the Contrast property of the custom shader
        imageMaterial.SetFloat("_Contrast", value);
    }

    public void ToggleInvertColors() {
        // Toggles a flag for inverting the colors.
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

    public void OnApplicationQuit() {
        // Calls the ResetMaterial() function when the scene is stopped
        ResetMaterial();
    }

    void ResetMaterial() {
        // Resets the material to the default values
        imageMaterial.color = defaultColor;
        imageMaterial.SetFloat("_Contrast", defaultContrast);
        imageMaterial.SetFloat("_Invert", 0);
    }
}
