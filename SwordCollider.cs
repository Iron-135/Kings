using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordCollider : MonoBehaviour
{
    [SerializeField] PlayerDamage playerDamage;

    void Start()
    {
        //playerDamage = GetComponentInParent<PlayerDamage>();
    }


    private void OnTriggerEnter(Collider other)
    {
        GameObject target = other.gameObject;

        if (target != null)
        {
            Debug.Log("Trigger Entered other");
            playerDamage.CmdAttack(target);
        }
        else return;
        
    }
}
