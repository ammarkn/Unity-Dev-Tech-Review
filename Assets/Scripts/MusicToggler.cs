using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicToggler : MonoBehaviour
{

    public Button musicTogglerButton;
    public GameObject music;

    // Start is called before the first frame update
    void Start()
    {
        music.SetActive(true);
        musicTogglerButton.onClick.AddListener(MusicToggle);
    }

    public void MusicToggle() {
        music.SetActive(!music.activeSelf);
    }
}
