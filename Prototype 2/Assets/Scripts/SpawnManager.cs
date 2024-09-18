using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject[] objects;
    private int spawnRangeX = 20;
    private int spawnPosZ = 20;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", 2, 1.5f);
    }

    void SpawnRandomAnimal()
    {
        int random = Random.Range(0, objects.Length);

        var animal = objects[random];
        var spawn = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0
            , spawnPosZ);

        Instantiate(animal, spawn, animal.transform.rotation);
    }
}
