using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GamemanagerScript : MonoBehaviour
{
    private static GamemanagerScript instance;
    //[SerializeField]
    //private FoodSpawner foodSpawner;
    private void Awake()
    {
        instance = this;
        //HighScore.InitialiseStatic();
        Time.timeScale = 1f;
        PlayerPrefs.SetInt("highscore", 100);
        PlayerPrefs.Save();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (IsGamePaused())
            {
                GamemanagerScript.resumeGame();
            }
            else
            {
                GamemanagerScript.pauseGame();
            }
        }
    }
    //public static void SnakeDied()
    //{
    //    bool isNewHighScore = HighScore.TrySetNewHighscore();
    //    GameOverWindow.ShowStatic(isNewHighScore);
    //    ScoreWindow.HideStatic();
    //}
    public static void resumeGame()
    {
        PauseWindow.HideStatic();
        Time.timeScale = 1f;
    }
    public static void pauseGame()
    {
        PauseWindow.ShowStatic();
        Time.timeScale = 0f;
    }
    public void startGame()
    {
        SceneManager.LoadScene("TutorialScene");
    }
    public void quitGame()
    {
        Application.Quit();
    }
    public static bool IsGamePaused()
    {
        return Time.timeScale == 0f;
    }
}
