using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class PlayerDamage : NetworkBehaviour
{
    [SerializeField] float attackDamage = 50f;

    [Command]
    public void CmdAttack(GameObject player)
    {
        player.GetComponent<PlayerHealth>().currentHealth -= attackDamage;
    }
}
