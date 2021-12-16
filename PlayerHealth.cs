using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class PlayerHealth : NetworkBehaviour
{
    [SyncVar] float maxHealth = 100f;
    [SyncVar (hook = nameof(TakenDamage))] public float currentHealth;

    void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakenDamage(float oldHealth, float newHealth)
    {
        Debug.Log("Hook Synced");

        if (newHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Debug.Log("Died");
        this.gameObject.SetActive(false);
    }
}

