using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object_Despawn_Manager : MonoBehaviour
{
    public Vector3 destroyCoordinates = new Vector3(-31, 0, 0); // Coordinates at which the object should be destroyed
    void Update()
    {
        if (transform.position.x <= destroyCoordinates.x)
        {
            Destroy(gameObject); // Destroy the object when it reaches the specified coordinates
        }
    }
}
