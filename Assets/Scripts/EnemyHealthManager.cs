using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealthManager : MonoBehaviour
{
    public int maxHealth = 1;
    private int currentHealth;

    public string deathSoundName;

    public GameObject deathEffect;
    public GameObject itemToDrop;


    void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage()
    {
        currentHealth--;
        if (currentHealth <= 0)
        {
            AudioManager.instance.PlaySoundEffect(deathSoundName);
            Destroy(gameObject);
            PlayerController.instance.Bounce();
            Instantiate(deathEffect, transform.position + new Vector3(0f, 1.2f, 0f), transform.rotation);
            if (itemToDrop != null)
            {
                Instantiate(itemToDrop, transform.position + new Vector3(0f, .5f, 0f), transform.rotation);
            }

        }
    }
}
