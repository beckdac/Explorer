﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    public void Explore()
    {
        Debug.Log("Explore");
        SceneManager.LoadScene(1);
    }

    public void Options()
    {
        Debug.Log("Options");
        SceneManager.LoadScene(2);
    }

    public void Quit()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
