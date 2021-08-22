using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;

public class Loader
{
    public enum Scene
    {
        StartScene,
        Loading,
        TutorialScene,
        Level1,
    }
    private static Action loaderCallbackAction;
    public static void Load(Scene scene)
    {
        loaderCallbackAction = () =>
        {
            SceneManager.LoadScene(scene.ToString());
        };
        SceneManager.LoadScene(Scene.Loading.ToString());
    }
    public static void LoaderCallback()
    {
        if (loaderCallbackAction != null)
        {
            loaderCallbackAction();
            loaderCallbackAction = null;
        }
    }
}
