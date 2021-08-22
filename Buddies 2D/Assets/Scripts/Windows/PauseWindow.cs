using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseWindow : MonoBehaviour
{
    public string CurrentScene;
    private static PauseWindow instance;
    private void Awake()
    {
        instance = this;
        Hide();
    }
    public void MainMenu()
    {
        //SoundManager.PlaySound(SoundManager.Sound.ButtonClick);
        Loader.Load(Loader.Scene.StartScene);
    }

    public void Resumebtn()
    {
        //SoundManager.PlaySound(SoundManager.Sound.ButtonClick);
        GamemanagerScript.resumeGame();
    }
    public void Restartbtn()
    {
        //SoundManager.PlaySound(SoundManager.Sound.ButtonClick);
        SceneManager.LoadScene(CurrentScene);
    }
    private void Show()
    {
        gameObject.SetActive(true);
    }
    private void Hide()
    {
        gameObject.SetActive(false);
    }
    public static void ShowStatic()
    {
        instance.Show();
    }
    public static void HideStatic()
    {
        instance.Hide();
    }
}
