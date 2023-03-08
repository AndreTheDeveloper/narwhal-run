using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class iceberg_spawn_manager : MonoBehaviour
{

    [SerializeField] List<GameObject> spawnableObjects;
    [SerializeField] public Vector3 spawnPosition;
    private float spawnDelay = 4.0f;
    private bool spawning = false;

    // Start is called before the first frame update
    void Start()
    {
        Spawn_Initiation();

        spawning = true;
        StartCoroutine(SpawnObject());
    }

    // Update is called once per frame
    void Update()
    {

    }

    void Spawn_Initiation()
    {
        int randomIndex = Random.Range(0, spawnableObjects.Count);
        GameObject objectToSpawn = spawnableObjects[randomIndex];

        // Spawn the object at the specified position
        Instantiate(objectToSpawn, spawnPosition, Quaternion.identity);
    }

    IEnumerator SpawnObject()
    {
        while (spawning)
        {
            // Wait for the specified delay before spawning the object
            yield return new WaitForSeconds(spawnDelay);

            // Select a random object from the list of objects to spawn
            int randomIndex = Random.Range(0, spawnableObjects.Count);
            GameObject objectToSpawn = spawnableObjects[randomIndex];

            // Spawn the object at the specified position
            Instantiate(objectToSpawn, spawnPosition, Quaternion.identity);
        }
    }

}
