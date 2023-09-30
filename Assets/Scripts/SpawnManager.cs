using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] AnimalPrefabs;
    private float _spawnRangeX = 20.0f;
    private float _spawnPositionZ = 20.0f;
    private float _spawnStartDelay = 2.0f;
    private float _spawnInterval = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", _spawnStartDelay, _spawnInterval);
    }

    void SpawnRandomAnimal()
    {        
        int animalIndex = Random.Range(0, AnimalPrefabs.Length);
        Vector3 spawnPosition = new Vector3(Random.Range(-_spawnRangeX, _spawnRangeX), 0, _spawnPositionZ);
        Instantiate(AnimalPrefabs[animalIndex], spawnPosition, AnimalPrefabs[animalIndex].transform.rotation);        
    }
}
