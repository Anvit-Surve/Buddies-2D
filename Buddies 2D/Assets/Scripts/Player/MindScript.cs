using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MindScript : MonoBehaviour
{
    public GameObject[] Players;
    [SerializeField] GameObject CurrentPlayer;

    void Start()
    {
        for (int i = 1; i < Players.Length; i++)
        {
            Players[i].GetComponent<MovementScript>().enabled = false;
        }
        CurrentPlayer = Players[0];
    }
    public void ChangePlayer(GameObject player)
    {
        CurrentPlayer.GetComponent<MovementScript>().enabled = false;
        CurrentPlayer = player;
    }

}
