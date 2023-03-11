using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin_behavior : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
{
    Destroy(gameObject);
}
}
