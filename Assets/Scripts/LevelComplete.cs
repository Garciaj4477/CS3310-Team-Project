﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour
{
    public void LoadNextLevel()
    {

        //if (SceneManager.sceneCountInBuildSettings > SceneManager.GetActiveScene().buildIndex + 1){}
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        
    }
}
