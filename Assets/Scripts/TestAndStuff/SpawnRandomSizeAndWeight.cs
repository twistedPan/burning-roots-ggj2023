using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnRandomSizeAndWeight : MonoBehaviour
{
    private Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        GetRandomProperties();
    }

    void Update()
    {
        if (transform.position.y < -10)
        {
            transform.position = new Vector3(25 + (5 * Random.value), 0, 25 + (5 * Random.value));
            GetRandomProperties();
        }
    }

    private void GetRandomProperties()
    {
        Vector3 randomScale = new Vector3(1 + Random.value * 5, 1 + Random.value * 5, 1 + Random.value * 5);
        transform.localScale = randomScale;
        rb.mass = (randomScale.x + randomScale.z) * 50;
        //rb.drag = rb.angularDrag = 60;
        transform.position += Vector3.up * 5;
    }
}
