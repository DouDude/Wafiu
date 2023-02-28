using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHunger : MonoBehaviour
{
    public float maxHunger = 100f;
    public float hungerDecreaseRate = 1f;
    public float hunger = 100f;
    public Slider hungerBar;
    public float hungerDeathThreshold = 10f;
    public Color fullColor = Color.green;
    public Color emptyColor = Color.red;

    private void Start()
    {
        hungerBar.maxValue = maxHunger;
        hungerBar.value = maxHunger;
    }

    private void Update()
    {
        hunger -= hungerDecreaseRate * Time.deltaTime;
        hunger = Mathf.Clamp(hunger, 0f, maxHunger);
        hungerBar.value = hunger;

        if (hunger <= 0f)
        {
            Die();
        }

        // set the color of the slider based on the player's hunger level
        float normalizedHunger = hunger / maxHunger;
        Color currentColor = Color.Lerp(emptyColor, fullColor, normalizedHunger);
        hungerBar.fillRect.GetComponent<Image>().color = currentColor;
    }
    public void AddHunger(float amount)
{
    hunger += amount;
    hunger = Mathf.Clamp(hunger, 0f, maxHunger);
    hungerBar.value = hunger;
}

    void Die()
    {
       transform.position = Vector3.zero;

        hunger = maxHunger;
    }
}