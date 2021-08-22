using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GamewonScript: MonoBehaviour
{
    public void GameWon(string NextScene)
    {
        if(GameObject.FindGameObjectWithTag("TOrange") == false && GameObject.FindGameObjectWithTag("TYellow") == false && GameObject.FindGameObjectWithTag("TOrange") == false)
        {
            Debug.Log("Level Complete");
            SceneManager.LoadScene(NextScene);
        }
    }
}
