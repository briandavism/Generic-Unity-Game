﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class LoadSceneButton : MonoBehaviour
{
    #region Private Variables
    private GameObject p_SceneController;
    #endregion

    #region Public Variables
    public GameObject sceneSelectorDropdown;
    #endregion

    #region Initialization Methods
    private void Start()
    {
        p_SceneController = GameObject.FindGameObjectWithTag("SceneController");
    }
    #endregion

    #region On Button Click
    public void LoadScene()
    {
        Dropdown dropdown = sceneSelectorDropdown.GetComponent<Dropdown>();
        string sceneName = dropdown.options[dropdown.value].text;

        if (!SceneManager.GetSceneByName(sceneName).isLoaded)
        {
            p_SceneController.GetComponent<SceneController>().AddScene(sceneName);
        }

        // TODO: Refactor into a ChangeScene, where the other dropdown scenes are unloaded and the
        // selected scene gets loaded.
    }
    #endregion
}
