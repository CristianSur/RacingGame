using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCars : MonoBehaviour
{
    public GameObject[] cars;
    int CarNr;
    public float maxPos = 1.75f;
    public float delayTimer = 2f;
    private float[] positions = { 1.73f, 0.56f, -0.58f, -1.69f };
    private float[] truckpositions = { -1.39f, 1f };
    float timer;

    // Use this for initialization
    void Start()
    {
        timer = delayTimer;

    }

    // Update is called once per frame
    void Update()
    {

        timer -= Time.deltaTime;

        if (timer <= 0)
        {
            CarNr = Random.Range(0, cars.Length);

            if (cars[CarNr].tag != "EnemyBigCar")
            { 
                Vector3 carPos = new Vector3(positions[Random.Range(0, positions.Length)], Random.Range(6f,9f), transform.position.z);
                Instantiate(cars[CarNr], carPos, Quaternion.Euler(new Vector3(0, 0, 180)));
                timer = delayTimer;
            }
            if (cars[CarNr].tag == "EnemyBigCar")
            {
                Vector3 truckPos = new Vector3(truckpositions[Random.Range(0, truckpositions.Length)], 9f, transform.position.z);
                Instantiate(cars[CarNr], truckPos, Quaternion.Euler(new Vector3(0, 0, 180)));
                timer = delayTimer;
            }
        }

    }
}