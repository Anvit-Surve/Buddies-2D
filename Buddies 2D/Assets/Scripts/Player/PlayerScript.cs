using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public MindScript mind;
    private void OnMouseDown()
    {
        mind.ChangePlayer(this.gameObject);
        GetComponent<MovementScript>().enabled = true;
    }
}
