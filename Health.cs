using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    //Code borrowed from: https://www.youtube.com/watch?v=aoZqeG7rqV0 

    public Image healthBar;
    public float healthAmount = 3;

    public void TakeDamage(float damage) {
        healthAmount -= damage;
        healthBar.fillAmount = healthAmount / 3;
        Debug.Log("Damage Taken. Health = " + healthAmount);
    }

    public void TakeHealth(float healPoints) {
        healthAmount += healPoints;
        healthAmount = Mathf.Clamp(healthAmount, 0, 3);
        healthBar.fillAmount = healthAmount / 3;
    }

}
