using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnRangeX = 16;
    private float spawnPosZ = 20;
    private float startDelay = 2;
    private float spawnInterval = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnAnimalRoutine());

    }
    private IEnumerator SpawnAnimalRoutine()
    {
        yield return new WaitForSeconds(startDelay);
        while (true)
        {
            int animalIndex = Random.Range(0, animalPrefabs.Length);
            Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
            Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
            yield return new WaitForSeconds(spawnInterval);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
       
    }

}
