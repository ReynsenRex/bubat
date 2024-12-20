using UnityEngine;
using UnityEngine.UI;

public class HPBar : MonoBehaviour
{
    public Image playerHPBar; // Health bar image
    public PlayerHealth playerHealth; // Reference to the PlayerHealth script
    private float maxHP = 100.0f; // Maximum health of the player
    private float speed = 1; // Speed of health bar animation

    // Update is called once per frame
    void Update()
    {
        // Get the player's current health and update the health bar
        if (playerHealth != null)
        {
            UpdateHP(playerHPBar, playerHealth.health, maxHP);
        }

        // Optional: Keep the health bar facing the camera (if needed)
        // Uncomment if the health bar is world-space UI
        // transform.rotation = Quaternion.LookRotation(transform.position - Camera.main.transform.position);
    }

    void UpdateHP(Image hpBar, float currentHP, float maxHP)
    {
        float target = currentHP / maxHP; // Calculate health as a fraction
        hpBar.fillAmount = Mathf.MoveTowards(hpBar.fillAmount, target, speed * Time.deltaTime); // Smoothly update the health bar
    }
}
