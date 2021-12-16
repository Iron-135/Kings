using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    [SerializeField] float attackDamage = 50f;

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Y");
        var health = collision.collider.GetComponent<Health>();

        if (health != null)
        {
            health.TakeDamage(attackDamage);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Y");
        var health = other.GetComponent<Health>();

        if (health != null)
        {
            health.TakeDamage(attackDamage);
        }
    }

}
