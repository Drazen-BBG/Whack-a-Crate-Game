using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    //Accessing RigidBody of all objects who have Target script attached
    private Rigidbody target_RB;

    //My variables, not to use hard coding in my methods. 
    private float minSpeed = 12.0f;
    private float maxSpeed = 15.0f;
    private float maxTorque = 10.0f;
    private float xRange = 4.0f;
    private float ySpawnPosition = -1.0f;

    // Start is called before the first frame update
    void Start()
    {
        //Assigning RB
        target_RB = GetComponent<Rigidbody>();
        //Adding Up force with an Impulse ForceMode and giving torque to crates
        target_RB.AddForce(RandomForce(), ForceMode.Impulse);
        target_RB.AddTorque(RandomTorque(), RandomTorque(), RandomTorque(), ForceMode.Impulse);

        //Giving random spawn position tom spawning crates
        transform.position = RandomSpawnPositition();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Execute code when clicked inside a collider 
    private void OnMouseDown()
    {
        Destroy(gameObject);
    }

    //Execute the code when enter collider trigger, we will use it on the sensor game object which has a collider trigger 
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }

    //My Methods

    //Returning random speed UP force
    Vector3 RandomForce()
    {
        return Vector3.up * Random.Range(minSpeed, maxSpeed);
    }

    //Returning a random float value for the purpose to fill the values of AddTorque
    float RandomTorque()
    {
        return Random.Range(-maxTorque, maxTorque);
    }

    //Returning a Vector3 random X position with a set Y and Z
    Vector3 RandomSpawnPositition()
    {
        return new Vector3(Random.Range(-xRange, xRange), ySpawnPosition, 0);
    }
}
