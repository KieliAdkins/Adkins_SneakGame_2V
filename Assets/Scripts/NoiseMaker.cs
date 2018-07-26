using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoiseMaker : MonoBehaviour {
    // Declaring the variables
    public CircleCollider2D volume;
    public float volumeRadius = 0f;

    private void Update()
    {
        volume.radius = volumeRadius; 
    }
}
