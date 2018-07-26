using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : Controller {

    // Declaring the required script connections
    public static PlayerController playerController;
    public static Pawn pawn;
    public static PawnBlue blueTank; 

    // Declaring our movement variables
    public float moveSpeed;
    public float turnSpeed; 

    // Declaring bullet related variables
    public GameObject tankBullet;
    public Transform bulletSpawn;

    private void Start()
    {
        // Declaring this script as the player controller
        playerController = this; 
    }
    // Update function
    private void Update()
    {
        blueTank.TankMove();

        if (Input.GetKeyDown(KeyCode.Space))
        {
           blueTank.TankShoot();
        }
    }
}
