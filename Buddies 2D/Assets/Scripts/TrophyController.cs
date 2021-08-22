using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrophyController : MonoBehaviour
{
    [SerializeField] private PlayerScript.PlayerType playerType;
    
    public PlayerScript.PlayerType GetPlayerType()
    {
        return playerType;
    }
}
