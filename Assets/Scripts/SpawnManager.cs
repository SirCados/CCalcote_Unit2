using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] AnimalPrefabs;
    private float _spawnRangeX = 20.0f;
    private float _spawnPositionZ = 25.0f;
   
    private void Update()
    {
        SpawnRandomAnimal();
    }

    void SpawnRandomAnimal()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            int animalIndex = Random.Range(0, AnimalPrefabs.Length);
            Vector3 spawnPosition = new Vector3(Random.Range(-_spawnRangeX, _spawnRangeX), 0, _spawnPositionZ);
            Instantiate(AnimalPrefabs[animalIndex], spawnPosition, AnimalPrefabs[animalIndex].transform.rotation);
        }
    }
}
