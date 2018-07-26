using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Pawn : PlayerController {

    // Start function
    private void Start()
    {
        // Declaring this script as the pawn
        pawn = this; 
    }

    // Tank movement function
    public virtual void TankMove()
    {
        Debug.Log("This is the parent movement.");
    }

    // Tank shooting function
    public virtual void TankShoot()
    {
        Debug.Log("This is the parent shooting.");
    }
}
