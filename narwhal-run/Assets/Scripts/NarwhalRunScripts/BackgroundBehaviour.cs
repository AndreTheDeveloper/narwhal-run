using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundBehaviour : MonoBehaviour
{
    
    public static float move_speed = 5f;
    public Vector3 destroyCoordinates = new Vector3(-31, 0, 0);

    // Start is called before the first frame update
    void Start()
    {
   
    }

    // Update is called once per frame
    void Update()
    {
        if (PauseController.isPaused == false)
        {
            transform.Translate(Vector3.left * move_speed * Time.deltaTime);

            if (DistanceController.totalDistance >= 50.0 && DistanceController.totalDistance < 150.0)
            {
                move_speed = DistanceController.velocity_2;
                transform.Translate(Vector3.left * move_speed * Time.deltaTime);
            }
            else if (DistanceController.totalDistance >= 150.0)
            {
                move_speed = DistanceController.velocity_3;
                transform.Translate(Vector3.left * move_speed * Time.deltaTime);
            }
        }

        if (transform.position.x <= destroyCoordinates.x)
        {
            Destroy(gameObject);
        }
    }

}
