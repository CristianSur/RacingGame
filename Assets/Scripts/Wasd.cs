using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wasd : MonoBehaviour
{

    public float ms = 15;

    public uiManager ui;


    void Start()
    {
     //   ui = GetComponent<uiManager>();
    }
    // Update is called one per frame
    void FixedUpdate()
    {

        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.up * ms * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector3.down * ms * Time.deltaTime);
        }


        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.left * ms * Time.deltaTime);
        }


        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right * ms * Time.deltaTime);
        }
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "EnemyCar" || col.gameObject.tag == "EnemyBigCar" || col.gameObject.tag == "Police")
        {
            Destroy(gameObject);
            ui.gameOverActivate();
        }

        if (col.gameObject.tag == "Ability")
        {
            
        }
    }
}
