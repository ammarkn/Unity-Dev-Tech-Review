using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageSelector : MonoBehaviour
{
    public GameObject firstImageObject;
    public GameObject secondImageObject;
    
    public Button firstImageButton;
    public Button secondImageButton;

    public GameObject firstImageQuad;
    public GameObject secondImageQuad;

    void Start() {
        firstImageObject.SetActive(false);
        secondImageObject.SetActive(false);

        firstImageButton.onClick.AddListener(() => SelectImage(firstImageObject));
        secondImageButton.onClick.AddListener(() => SelectImage(secondImageObject));
    }

    void SelectImage(GameObject selectedImage) {
        firstImageButton.gameObject.SetActive(false);
        secondImageButton.gameObject.SetActive(false);

        firstImageQuad.SetActive(false);
        secondImageQuad.SetActive(false);

        selectedImage.SetActive(true);
    }
}
