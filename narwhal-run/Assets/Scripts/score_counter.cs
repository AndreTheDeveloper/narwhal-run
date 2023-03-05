using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class score_counter : MonoBehaviour
{
    public TextMeshPro textMesh; // Assign this in the inspector to the TextMeshPro component you want to increment
    public string tagToDetect = "coins"; // Assign this in the inspector to the tag you want to detect collisions with

    private int collisionCount = 0;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag(tagToDetect))
        {
            collisionCount++;
            textMesh.text = collisionCount.ToString();
        }
    }
}
