using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvertImageColors : MonoBehaviour
{
    
    private bool isInverted = false;
    public Material imageMaterial;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void ToggleInvertColors() {
        isInverted = !isInverted;
        UpdateColors();
    }

    public void UpdateColors() {
        if(isInverted) {
            imageMaterial.color = Color.white - imageMaterial.color;
        }
        else {

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
