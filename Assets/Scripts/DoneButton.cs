using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoneButton : MonoBehaviour
{

    public GameObject firstImageEditor;
    public GameObject secondImageEditor;
    public GameObject imageSelector;

    public Button doneButton;
    public Button doneButton2;
    
    public Button firstImageButton;
    public Button secondImageButton;

    // Start is called before the first frame update
    void Start()
    {
        // Adds listener to both the Done buttons to call the required function
        doneButton.onClick.AddListener(() => Done());
        doneButton2.onClick.AddListener(() => Done());
    }

    void Done() 
    {
        // Hides the editors for both images
        firstImageEditor.SetActive(false);
        secondImageEditor.SetActive(false);

        // Displays the image selection screen
        imageSelector.SetActive(true);
        firstImageButton.gameObject.SetActive(true);
        secondImageButton.gameObject.SetActive(true);
    }
}
