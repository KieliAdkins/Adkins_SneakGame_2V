using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PercentageBar : MonoBehaviour
{
    // UI's health bar
    public Slider healthSlider;

    // Update function
    void Update()
    {
        // Setting the slider value
        healthSlider.value = GameManager.instance.playerLives;
    }
}