﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToMenu : MonoBehaviour
{
    
    public void BacktoMenu () 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }   
}