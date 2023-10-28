using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageSelector : MonoBehaviour
{
    public GameObject quad1;
    public GameObject quad2;

    public void ShowImage1() {
        quad1.SetActive(true);
        quad2.SetActive(false);
    }

    public void ShowImage2() {
        quad1.SetActive(false);
        quad2.SetActive(true);
    }
}
