using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpaceScene : MonoBehaviour {

    void OnGUI()
    {
        if (GUI.Button(new Rect(Screen.width/2, 10, 100, 20), "Open Planet"))
        {
            SceneManager.LoadScene("EarthScene");
        }
    }
}
