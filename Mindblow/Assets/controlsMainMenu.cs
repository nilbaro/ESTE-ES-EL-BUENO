﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class controlsMainMenu : MonoBehaviour {

    public void goBack()
    {
        SceneManager.LoadScene("Main Menu");
    }

}
