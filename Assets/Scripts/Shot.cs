using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour
{
    // Declaring our variables
    public float moveSpeed;
    public float lifeSpan; 
    private Transform tf;

    // Use this for initialization
    void Start()
    { 
        // Acquiring component for movement
        tf = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        // Changing the position of the Game Object
        tf.position = tf.position + (GetComponent<Transform>().up * moveSpeed);

        // Destroying the bullet overtime
        Destroy(gameObject, lifeSpan);
    }

    // What happens on collision
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Sandbags")
        {
            // Destroy the bullet itself
            Destroy(gameObject);
        }
    }
}
