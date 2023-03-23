using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DistanceController : MonoBehaviour
{
    public float move_speed;
    public Text distanceText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(PauseController.isPaused == false) {
            distanceText.text = (Mathf.RoundToInt(move_speed * Time.time)).ToString() + " m";
        }
    }
}
