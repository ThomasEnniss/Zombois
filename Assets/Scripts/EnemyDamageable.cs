using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamageable : MonoBehaviour, IDamageAble
{

    public GameObject scorekeeper;

    public delegate void Death();
    public event Death Dead;

    private void Start()
    {
        scorekeeper = GameObject.FindGameObjectWithTag("ScoreKeeper");
    }

    private void OnCollisionEnter(Collision collision)
    {
        Damage(collision.gameObject);
    }

    public void Damage(GameObject other)
    {
        if (other.CompareTag("Bullet"))
        {
            Die();
        }
    }

    public void Die()
    {
        Dead();
        Destroy(gameObject);
    }
}
