using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIRed : AIPawn {

    // Declaring the variables
    public Transform tf;
    public Rigidbody2D rb; 

    // Start function
    private void Start()
    {
        // Capturing the transform component
        tf = GetComponent<Transform>();

        // Capturing the transform component
        rb = GetComponent<Rigidbody2D>();

        // Connecting the script to the AIController script
        AIController.redTank = this; 
    }

    // Field of view function
    public override bool TankField()
    {
        // Setting the collider
        Collider2D targetCollider = target.GetComponent<Collider2D>();

        // If it is not the target collider than we do not see it
        if (targetCollider == null)
        {
            return false;
        }

        // Getting the target's transform
        Transform targetTransform = target.GetComponent<Transform>();

        // Checking the validity of the above component capture
        if (targetTransform == null)
        {
            return false;
        }

        else if (tf == null)
        {
            return false; 
        }

        // Finding the distance between the target and enemy
        Vector3 vectorToTarget = targetTransform.position - tf.position;

        // Finding the angle between the target and enemy
        float angle = Vector3.Angle(vectorToTarget, tf.right);

        // If the angle is larger than our field of view do nothing
        if (angle < fieldOfView)
        {
            // Otherwise send out a raycast
            RaycastHit2D hitInfo = Physics2D.Raycast(tf.position, vectorToTarget, viewDistance);

            // if our raycast hit nothing they are not there
            if (hitInfo.collider.gameObject == null)
            {
                return false;
            }

            // If our raycast hit them first, then we can see them
            else if (hitInfo.collider.gameObject == target)
            {
                // Calling the move function
                Move(); 

                // Returning out of the statement
                return true;
            }
        }

        return false; 
    }

    // On collision effects
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // If it is a bullet give player points
        if (collision.gameObject.tag == "Shot")
        {
            // Destroying the tank if it is hit by something
            Destroy(gameObject);

            // Adding 1000 points to the player's score
            GameManager.instance.playerScore += pointValue;
        }

        else if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);

            // Destroying the collision object
            GetComponent<PawnDestroy>(); 

        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        // Getting the player's noisemaker component
        NoiseMaker other = target.GetComponent<NoiseMaker>();

        // If it is not present, than we get null and output that
        if (other == null)
        {
            // Do Nothing
            hearPlayer = false;
        }

        // If it is not than we do some functions
        else if (other == other.volume)
        {

            hearPlayer = true;
        }
    }
}
