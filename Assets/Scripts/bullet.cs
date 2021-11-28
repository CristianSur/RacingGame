using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public float speed = 5f;
    public Rigidbody2D rb;
    public int damage = 1;


    void Start()
    {
        rb.velocity = transform.up * speed;
    }

    private void OnTriggerEnter2D(Collider2D hitInfo)
    {
        EnemyHit enemy = hitInfo.GetComponent<EnemyHit>();

        if (hitInfo.gameObject.tag != "Ability")
        {
            if (enemy != null)
            {
                enemy.TakeDamage(damage);
            }
            Destroy(gameObject);
        }
    }

    private void FixedUpdate()
    {
        if (transform.position.y > 4.5f)
            Destroy(gameObject);
    }
}
