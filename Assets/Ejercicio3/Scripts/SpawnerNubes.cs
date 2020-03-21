using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerNubes : MonoBehaviour
{
    public GameObject prefabNube;
    public float tiempoEntreSpawns, spawnRandomRange;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObstaculo", 0F, tiempoEntreSpawns);
    }

    void SpawnObstaculo()
    {

        Vector3 posicionVertical;

        posicionVertical.x = 0.0f;
        posicionVertical.y = Random.Range(-spawnRandomRange, +spawnRandomRange);
        posicionVertical.z = 0.0f;

        Instantiate(prefabNube, transform.position + posicionVertical, Quaternion.identity);
    }
}
