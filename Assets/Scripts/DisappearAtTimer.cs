using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Diagnostics;

public class DisappearAtTimer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
