using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background_Manager : MonoBehaviour
{
    [SerializeField] List<GameObject> Clouds;
    [SerializeField] GameObject Bubble;
    [SerializeField] public Vector3 Cloud_0_Position;
    [SerializeField] public Vector3 Cloud_1_Position;
    [SerializeField] public Vector3 Cloud_2_Position;
    [SerializeField] public Vector3 Cloud_3_Position;
    [SerializeField] public Vector3 Cloud_4_Position;
    [SerializeField] public Vector3 Cloud_5_Position;
    [SerializeField] public Vector3 Cloud_6_Position;
    [SerializeField] public Vector3 Cloud_7_Position;
    [SerializeField] public Vector3 Cloud_8_Position;
    [SerializeField] public Vector3 Cloud_9_Position;
    [SerializeField] public Vector3 Cloud_10_Position;
    [SerializeField] public Vector3 Cloud_11_Position;
    public float cloudSpawnDelay = 1.5f;
    public float bubbleSpawnDelay = 1f;
    public static bool spawning = false; 

    // Start is called before the first frame update
    void Start()
    {
        spawning = true;
        StartCoroutine(SpawnClouds());
        StartCoroutine(SpawnBubbles());
    }

    // Update is called once per frame
    void Update()
    {
        if (PauseController.isPaused)
        {
            spawning = false;
        }
    }

    IEnumerator SpawnClouds()
    {
        while (spawning)
        {
            int randomIndex = Random.Range(0, 11);
            if(randomIndex == 0)
            {
                GameObject cloudToSpawn = Clouds[randomIndex];
                Instantiate(cloudToSpawn, Cloud_0_Position, Quaternion.identity);
            }
            else if (randomIndex == 1)
            {
                GameObject cloudToSpawn = Clouds[randomIndex];
                Instantiate(cloudToSpawn, Cloud_1_Position, Quaternion.identity);
            }
            else if (randomIndex == 2)
            {
                GameObject cloudToSpawn = Clouds[randomIndex];
                Instantiate(cloudToSpawn, Cloud_2_Position, Quaternion.identity);
            }
            else if (randomIndex == 3)
            {
                GameObject cloudToSpawn = Clouds[randomIndex];
                Instantiate(cloudToSpawn, Cloud_3_Position, Quaternion.identity);
            }
            else if (randomIndex == 4)
            {
                GameObject cloudToSpawn = Clouds[randomIndex];
                Instantiate(cloudToSpawn, Cloud_4_Position, Quaternion.identity);
            }
            else if (randomIndex == 5)
            {
                GameObject cloudToSpawn = Clouds[randomIndex];
                Instantiate(cloudToSpawn, Cloud_5_Position, Quaternion.identity);
            }
            else if (randomIndex == 6)
            {
                GameObject cloudToSpawn = Clouds[randomIndex];
                Instantiate(cloudToSpawn, Cloud_6_Position, Quaternion.identity);
            }
            else if (randomIndex == 7)
            {
                GameObject cloudToSpawn = Clouds[randomIndex];
                Instantiate(cloudToSpawn, Cloud_7_Position, Quaternion.identity);
            }
            else if (randomIndex == 8)
            {
                GameObject cloudToSpawn = Clouds[randomIndex];
                Instantiate(cloudToSpawn, Cloud_8_Position, Quaternion.identity);
            }
            else if (randomIndex == 9)
            {
                GameObject cloudToSpawn = Clouds[randomIndex];
                Instantiate(cloudToSpawn, Cloud_9_Position, Quaternion.identity);
            }
            else if (randomIndex == 10)
            {
                GameObject cloudToSpawn = Clouds[randomIndex];
                Instantiate(cloudToSpawn, Cloud_10_Position, Quaternion.identity);
            }
            else if (randomIndex == 11)
            {
                GameObject cloudToSpawn = Clouds[randomIndex];
                Instantiate(cloudToSpawn, Cloud_11_Position, Quaternion.identity);
            }

            yield return new WaitForSeconds(cloudSpawnDelay); 
        }
    }

    IEnumerator SpawnBubbles()
    {
        while (spawning)
        {
            GameObject bubbleToSpawn = Bubble;
            float randomY = Random.Range(-1.27f, -4.48f);
            Vector3 bubblePosition = new Vector3(20f, randomY, 0f);
            Instantiate(bubbleToSpawn, bubblePosition, Quaternion.identity);
            yield return new WaitForSeconds(bubbleSpawnDelay);
        }
    }


}
