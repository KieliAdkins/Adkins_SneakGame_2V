using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PawnDestroy : MonoBehaviour {

    private void OnDestroy()
    {
        // Repositioning the player
        transform.position = GetComponent<Transform>().position + Vector3.zero;

        // Subtracting a life
        GameManager.instance.playerLives -= 1;
    }
}
