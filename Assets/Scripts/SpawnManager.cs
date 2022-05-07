using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] AnimalPrefabs;
    [SerializeField] private float spawnRangeX = 16;
    [SerializeField] private float spawnPosZ = 20;
    [SerializeField] private float startDelay = 2;
    [SerializeField] private float spawnInterval = 1.5f;

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
            int animalIndex = Random.Range(0, AnimalPrefabs.Length);
            Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
            Instantiate(AnimalPrefabs[animalIndex], spawnPos, AnimalPrefabs[animalIndex].transform.rotation);
            yield return new WaitForSeconds(spawnInterval);
        }
    }
}
