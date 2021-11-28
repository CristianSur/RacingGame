using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class MoveAndSpawn : MonoBehaviour
{
    public float speed = 1.5f;

    void FixedUpdate()
    {
        transform.Translate(Vector3.down * speed * Time.deltaTime);

        if (transform.position.y < -9f)
        {
            transform.position = new Vector3(0, 15.86f, 0);
            // Instantiate(gameObject, new Vector3(0, 15.86f, 0), Quaternion.identity);
            // Destroy(gameObject);
        }
    }
}