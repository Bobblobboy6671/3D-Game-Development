using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectTeleport : MonoBehaviour
{
    public Transform spawnPoint;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Ball") // chech that collider entering trigger is tagged 'ball'
        {
            if(other.TryGetComponent(out Rigidbody rb) ==true)//get rigidbody from colliding object
            {
                rb.velocity = Vector3.zero;// reset rididbody velociry to 0 to stop movement
            }
            other.transform.position = spawnPoint.position; //move colliding object to spawn point position
        }
    }
}
