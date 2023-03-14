using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin_behavior : MonoBehaviour
{
    public float move_speed = 5f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(PauseController.isPaused == false)
            transform.Translate(Vector3.left * move_speed * Time.deltaTime);
    }
    void OnCollisionEnter2D(Collision2D collision)
{
    Destroy(gameObject);
}

}
