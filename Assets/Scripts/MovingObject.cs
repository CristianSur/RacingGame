using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingObject : MonoBehaviour
{
    public float speed = 2f;
    public EnemyHit bo;

    private void Start()
    {
       bo  = FindObjectOfType<EnemyHit>();
    }
    void FixedUpdate()
    {
        transform.Translate(Vector3.up * speed * Time.deltaTime);

        if(transform.position.y < -10f)
            Destroy(gameObject);
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "EnemyBigCar")
        {
            Destroy(gameObject);
            Vector3 boomPos = new Vector3(transform.position.x, transform.position.y, transform.position.z);
            Instantiate(bo.Boom, boomPos, Quaternion.identity);
        }
        if (col.gameObject.tag == "Police" && gameObject.tag == "EnemyCar")
        {
            Destroy(gameObject);
            Vector3 boomPos = new Vector3(transform.position.x, transform.position.y, transform.position.z);
            Instantiate(bo.Boom, boomPos, Quaternion.identity);
        }
        if (col.gameObject.tag == "EnemyCar" && gameObject.tag == "EnemyCar")
        {
            Destroy(gameObject);
            Vector3 boomPos = new Vector3(transform.position.x, transform.position.y, transform.position.z);
            Instantiate(bo.Boom, boomPos, Quaternion.identity);
        }
    }
}

