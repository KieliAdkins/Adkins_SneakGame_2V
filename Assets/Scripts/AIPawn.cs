using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AIPawn : AIController
{
    // Declaring our variables

    // Start function
    private void Start()
    {
        // Declaring this script as the pawn
        AIController.aiPawn = this;
    }

    // Declaring our tank movement
    public virtual void Move()
    {
        // Declaring our enemy's rotation
        Vector3 vectorToTarget = target.transform.position - redTank.tf.position;
        float angle = Mathf.Atan2(vectorToTarget.y, vectorToTarget.x) * Mathf.Rad2Deg;
        Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
        redTank.tf.rotation = Quaternion.Slerp(redTank.tf.rotation, q, Time.deltaTime * turnSpeed);
        // Declaring our enemy's movement
        float step = moveSpeed * Time.deltaTime;
        redTank.tf.position = Vector3.MoveTowards(redTank.tf.position, target.transform.position, step);
    }

    // Declaring our tank field of view
    public virtual bool TankField()
    {
        Debug.Log("This is the parent field of view.");

        return false;  
    }

    // Rest function
    public virtual void DoRest()
    {
        // Increase our health
       health += restingHealRate;
        // But never go over our max health
       health = Mathf.Min(health, maxHealth);
    }

}