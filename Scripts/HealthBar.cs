using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public int health = 20;
    public Image healthBar;

    public void TakeDamage(int damage)
    {
        health -= damage;

        healthBar.fillAmount = health / 20f;

        if (health <= 0)
        {
            //instantiate gameover scherm
        }
    }
}
