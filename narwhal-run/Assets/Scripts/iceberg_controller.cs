using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class iceberg_controller : MonoBehaviour
{
    public float move_speed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * move_speed * Time.deltaTime);
    }
}
