using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PawnBlue : Pawn {

    // Declaring our variables
    private Transform tf;

    // Use this for initialization
    void Start()
    {
        // Declaring this script as the pawn
        blueTank = this;


        // Capturing the player's location
        tf = GetComponent<Transform>();
    }

    // Tank movement function
    public override void TankMove()
    {
        // if statement for up key controlled movement
        if (Input.GetKey(KeyCode.UpArrow))
        {
            tf.position = tf.position + (GetComponent<Transform>().up * moveSpeed * Time.deltaTime);
        }

        // if statement for right key controlled movement
        if (Input.GetKey(KeyCode.RightArrow))
        {
            tf.Rotate(0, 0, -turnSpeed);
        }

        // if statement for left key controlled movement
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            tf.Rotate(0, 0, turnSpeed);

        }

        // if statement for down key controlled movement
        if (Input.GetKey(KeyCode.DownArrow))
        {
            tf.position = tf.position + (-GetComponent<Transform>().up * moveSpeed * Time.deltaTime);
        }
    }

    public override void TankShoot()
    {
        Instantiate(tankBullet, bulletSpawn.position, bulletSpawn.rotation);
    }

    private void OnDestroy()
    {
        // Repositioning the player
        tf.position = tf.position + Vector3.zero;

        // Subtracting a life
        GameManager.instance.playerLives -= 1; 
    }
}
