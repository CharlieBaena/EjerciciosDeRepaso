using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerObjects : MonoBehaviour
{
    public GameObject prefabMoneda, prefabBarrera, prefabAgujero;
    public float tiempoEntreSpawns, spawnRandomRange;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObstaculo", 0F, tiempoEntreSpawns);
    }

    void SpawnObstaculo()
    {
        int random = Random.Range(0, 3);

        Vector3 posicionVertical;

        posicionVertical.x = Random.Range(-spawnRandomRange, +spawnRandomRange);
        posicionVertical.y = 0.0f;
        posicionVertical.z = 0.0f;

        switch (random)
        {
            case 0:
                Instantiate(prefabMoneda, transform.position + posicionVertical, Quaternion.identity);
                break;

            case 1:
                Instantiate(prefabBarrera, transform.position + posicionVertical, Quaternion.identity);
                break;

            case 2:
                Instantiate(prefabAgujero, transform.position + posicionVertical, Quaternion.identity);
                break;
        }
    }
}
