using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public string NextScene;
    public GamewonScript gamewon;
    public MindScript mind;
    [SerializeField] private PlayerType playerType;
    public enum PlayerType
    {
        Orange,
        Yellow,
        Green
    }
    private void OnMouseDown()
    {
        mind.ChangePlayer(this.gameObject);
        GetComponent<MovementScript>().enabled = true;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        TrophyController trophyController = collision.GetComponent<TrophyController>();
        if (trophyController != null)
        {
            if (trophyController.GetPlayerType() == playerType)
            {
                Destroy(trophyController.gameObject);
                gamewon.GameWon(NextScene);
            }
        }
    }
}
