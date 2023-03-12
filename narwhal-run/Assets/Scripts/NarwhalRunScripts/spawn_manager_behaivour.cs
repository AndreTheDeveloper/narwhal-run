using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn_manager_behaivour : MonoBehaviour
{

    [SerializeField] List<GameObject> spawnableObjects;
    [SerializeField] List<GameObject> pickups;
    [SerializeField] List<Vector3> coinCordinates;
    [SerializeField] public Vector3 icebergSpawnPosition;
    private float spawnDelay = 4.0f;
    private bool spawning = false;

    // Start is called before the first frame update
    void Start()
    {
        Spawn_Initiation();

        spawning = true;
        StartCoroutine(SpawnObjects());
    }

    // Update is called once per frame
    void Update()
    {

    }

    void Spawn_Initiation()
    {
        int randomIndex = Random.Range(0, 4);
        GameObject icebergToSpawn = spawnableObjects[randomIndex];

        // Spawn the object at the specified position
        Instantiate(icebergToSpawn, icebergSpawnPosition, Quaternion.identity);
    }

    IEnumerator SpawnObjects()
    {
        while (spawning)
        {
            // Wait for the specified delay before spawning the object
            yield return new WaitForSeconds(spawnDelay);

            // Select a random object from the list of objects to spawn
            int randomIndex = Random.Range(0, 4);
            GameObject icebergToSpawn = spawnableObjects[randomIndex];

            // Will check to see if a coin should be spawned, if a coin should be spawned then it will spawn a number of coins with an iceberg
            int willCoinSpawn = Random.Range(1, 100);
            if (willCoinSpawn <= 30)
            {
                if(randomIndex == 0)
                {
                    // Spawn the object at the specified position
                    GameObject coin = spawnableObjects[5];
                    Instantiate(coin, coinCordinates[0], Quaternion.identity);
                    // Spawn the object at the specified position
                    Instantiate(icebergToSpawn, icebergSpawnPosition, Quaternion.identity);
                }

                else if (randomIndex == 1)
                {
                    // Spawn the object at the specified position
                    GameObject coin = spawnableObjects[5];
                    Instantiate(coin, coinCordinates[0], Quaternion.identity);
                    // Spawn the object at the specified position
                    Instantiate(icebergToSpawn, icebergSpawnPosition, Quaternion.identity);
                }

                else if(randomIndex == 2)
                {
                    // Spawn the object at the specified position
                    GameObject coin = spawnableObjects[5];
                    Instantiate(coin, coinCordinates[1], Quaternion.identity);
                    // Spawn the object at the specified position
                    Instantiate(icebergToSpawn, icebergSpawnPosition, Quaternion.identity);
                }

                else if(randomIndex == 3)
                {
                    // Spawn the object at the specified position
                    int randomCoin = Random.Range(0, coinCordinates.Count);
                    GameObject coin = spawnableObjects[5];
                    Instantiate(coin, coinCordinates[randomCoin], Quaternion.identity);
                    // Spawn the object at the specified position
                    Instantiate(icebergToSpawn, icebergSpawnPosition, Quaternion.identity);
                }

                else if(randomIndex == 4)
                {
                    // Spawn the object at the specified position
                    int randomCoin = Random.Range(0, coinCordinates.Count);
                    GameObject coin = spawnableObjects[5];
                    Instantiate(coin, coinCordinates[randomCoin], Quaternion.identity);
                    // Spawn the object at the specified position
                    Instantiate(icebergToSpawn, icebergSpawnPosition, Quaternion.identity);
                }
            }

            else
            {   
                // Spawn the object at the specified position
                Instantiate(icebergToSpawn, icebergSpawnPosition, Quaternion.identity);
            }
        }
    }

}
