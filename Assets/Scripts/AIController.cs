using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIController : Controller {

    // Declaring the required script connections
    public static AIController aiController;
    public static AIPawn aiPawn;
    public static AIRed redTank;

    // Enemy movement variables
    public float moveSpeed;
    public float turnSpeed;

    // Enemy health variables
    public float cutoff; 
    public float health;
    public float restingHealRate;
    public float maxHealth; 

    // Enemy point value
    public int pointValue;

    // Enemy's target variable
    public GameObject target;
    
    // Enemy field of view variables
    public float fieldOfView = 45.0f;
    public float viewDistance;

    // Enemy hearing variables
    public float hearingRadius = 0f;
    public CircleCollider2D hearing;
    public bool hearPlayer; 

    private void Update()
    {
        // Calling the parent function
        redTank.TankField();
    }
}
