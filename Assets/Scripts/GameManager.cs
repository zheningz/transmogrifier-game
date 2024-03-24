using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject canvas;

    void Update()
    {
        if (OVRInput.GetDown(OVRInput.Button.Start))
        {
            canvas.SetActive(!canvas.activeSelf);
        }
    }
}
