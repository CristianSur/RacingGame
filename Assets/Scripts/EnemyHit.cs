using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHit : MonoBehaviour
{
    public uiManager ui;
    public GameObject Boom;
    public int health = 2;
    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Die();
        }
    }
    private void Start()
    {

        ui = FindObjectOfType<uiManager>();
        
    }
    void Die()
    {
        Destroy(gameObject);
        ui.score += 5;
        Vector3 boomPos = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        Instantiate(Boom, boomPos, Quaternion.identity);
    }
}
