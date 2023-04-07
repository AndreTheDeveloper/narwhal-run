using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background_Manager : MonoBehaviour
{
    [SerializeField] List<GameObject> spawnableObjects;
    [SerializeField] public Vector3 BackgroundSpawnPosition;
    [SerializeField] public Vector3 InitialSpawnPosition;
    public static bool spawning = false; 

    // Start is called before the first frame update
    void Start()
    {   
        GameObject Background = spawnableObjects[0];
        Instantiate(Background, InitialSpawnPosition, Quaternion.identity);
        Instantiate(Background, BackgroundSpawnPosition, Quaternion.identity);
        spawning = true;
        StartCoroutine(SpawnBackground());
    }

    // Update is called once per frame
    void Update()
    {
    
    }

    IEnumerator SpawnBackground()
    {
        while (spawning)
        {
            GameObject Background = spawnableObjects[0];
            if (Background.transform.position.x <= 0.04 && gameObject.transform.position.x >= 0.00)
            {
                Instantiate(Background, BackgroundSpawnPosition, Quaternion.identity);
                yield return new WaitForSeconds(5f);
            }
            else { }
        }
    }


}
