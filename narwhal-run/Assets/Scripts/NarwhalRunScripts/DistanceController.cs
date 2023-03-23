using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DistanceController : MonoBehaviour
{
    public Text distanceText;

    public static float totalDistance = 0;
    private float time_1 = 0;
    private float time_2 = 0;
    private float time_3 = 0;
    private float distance_1 = 0;
    private float distance_2 = 0;
    private float distance_3 = 0;
    private float velocity_1 = 5;
    public static float velocity_2 = 7;
    public static float velocity_3 = 9;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(distance());
    }

    // Update is called once per frame
    void Update()
    {
        if(PauseController.isPaused == false) {
            distanceText.text = totalDistance + " m";
        }
    }

    IEnumerator distance() 
    {
        while(true) {
            if(PauseController.isPaused == false) {
                if (totalDistance <= 50){
                    yield return new WaitForSeconds(1f);
                    time_1 += 1;
                    distance_1 = time_1 * velocity_1;
                    totalDistance = distance_1;
                }
                else if(totalDistance >= 50 && totalDistance <= 100)
                {
                    yield return new WaitForSeconds(1f);
                    time_2 += 1;
                    distance_2 = time_2 * velocity_2;
                    totalDistance = distance_1 + distance_2;

                }
                else if(totalDistance >= 100)
                {
                    yield return new WaitForSeconds(1f);
                    time_3 += 1;
                    distance_3 = time_3 * velocity_3;
                    totalDistance = distance_1 + distance_2 + distance_3;  
                }
            }
            else {
                break;
            }
        }
    }
}
