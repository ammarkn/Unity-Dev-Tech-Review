using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageSelector : MonoBehaviour
{
    public GameObject imageSelectorObject;
    public GameObject firstImageEditor;
    public GameObject secondImageEditor;

    public Button firstImageButton;
    public Button secondImageButton;

    void Start() {
        // Hides the editors for both images
        firstImageEditor.SetActive(false);
        secondImageEditor.SetActive(false);

        // Adds listener to each of the edit buttons to call the required function
        firstImageButton.onClick.AddListener(() => SelectImage(firstImageEditor));
        secondImageButton.onClick.AddListener(() => SelectImage(secondImageEditor));
    }

    void SelectImage(GameObject selectedImage) {
        // Hides the edit buttons for both images
        firstImageButton.gameObject.SetActive(false);
        secondImageButton.gameObject.SetActive(false);

        // Hides the image selection menu
        imageSelectorObject.SetActive(false);

        // Opens the editor for the selected image
        selectedImage.SetActive(true);
    }
}
