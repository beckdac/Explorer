using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OptionsMenu : MonoBehaviour {

    public void MainMenu()
    {
        Debug.Log("MainMenu");
        SceneManager.LoadScene(0);
    }

    public void Quit()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
