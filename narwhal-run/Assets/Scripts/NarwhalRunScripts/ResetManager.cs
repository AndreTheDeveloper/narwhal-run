using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetManager : MonoBehaviour
{
    public void resetDistance() {
        DistanceController.totalDistance = 0;
    }
}
