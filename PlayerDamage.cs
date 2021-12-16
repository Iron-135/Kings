using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class PlayerDamage : NetworkBehaviour
{
    [SerializeField] float attackDamage = 50f;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Y");
        var health = other.GetComponent<Health>();
        var playerHealth = other.GetComponent<PlayerHealth>();
        GameObject target = other.gameObject;
        

        if (health != null)
        {
            health.TakeDamage(attackDamage);
        }
    
        if (playerHealth != null)
        {
            CmdAttack(target);
        }
    }

    [Command]
    public void CmdAttack(GameObject player)
    {
        player.GetComponent<PlayerHealth>().currentHealth -= attackDamage;
    }
}
