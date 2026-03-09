using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public float maxHealth = 100f;
    public float currentHealth;

    public Slider healthSlider;

    private PlayerController env;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentHealth = maxHealth;
        healthSlider.maxValue = maxHealth;
        healthSlider.value = currentHealth;

        env = GetComponent<PlayerController>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            TakeDamage(10f);
        }
        healthSlider.value = Mathf.Lerp(healthSlider.value, currentHealth, Time.deltaTime * 10);
    }

    public void TakeDamage(float amount)
    {
        //Debug.Log("Before damage: " + currentHealth);
        currentHealth -= amount;
        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);
        //Debug.Log("Health: " + currentHealth);
        //healthSlider.value = currentHealth;

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        // Freezes the game
        Time.timeScale = 0f;
    }
}
