using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerHealth : MonoBehaviour
{

    public int health;
    public int currentHealth;

    public bool isDead;
    public HealthBarManager sliderHp;

    private void Start()
    {
        health = 50;
        currentHealth = health;


        isDead = false;

        sliderHp.SetMaxHealth(health);
        sliderHp.SetHealth(currentHealth);
    }

    private void Update()
    {
        if (currentHealth > health)
        {
            currentHealth = health;
        }


        sliderHp.SetHealth(currentHealth);

        if (currentHealth == 0)
        {
            isDead = true;
        }
    }

    //Prepare the maximum value for the slider component


}
