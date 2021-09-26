using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    private Rigidbody target_RB;
    // Start is called before the first frame update
    void Start()
    {
        target_RB = GetComponent<Rigidbody>();

        target_RB.AddForce(Vector3.up * Random.Range(12, 18), ForceMode.Impulse);
        target_RB.AddTorque(Random.Range(-10, 10), Random.Range(-10, 10), Random.Range(-10, 10), ForceMode.Impulse);

        transform.position = new Vector3(Random.Range(-4, 4), -1, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
