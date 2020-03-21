using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio1 : MonoBehaviour
{
    public GameObject prefabObstacle;

    // Start is called before the first frame update
    void Start()
    {
        int x = 5;
        int y = 3;

        GameObject temp = SpawnObstacleA();
        Debug.Log(temp.GetComponent<SpriteRenderer>().name);
        SpawnObstacleB();
        SpawnObstacleIn(new Vector2(x,y));
        SpawnNObstacles(5);
    }

    // Update is called once per frame
    void Update()
    {        
        int x = Random.Range(-8, 8);
        int y = Random.Range(-8, 8);
        //SpawnObstacleB();
        SpawnObstacleIn(new Vector2(x, y));
    }

    //a
    GameObject SpawnObstacleA()
    {
        GameObject obstacle = Instantiate(prefabObstacle);
        return obstacle;
    }

    //b
    void SpawnObstacleB()
    {
        Instantiate(prefabObstacle);
    }

    //c
    void SpawnObstacleIn(Vector2 position)
    {
        Instantiate(prefabObstacle, position, Quaternion.identity);
    }

    //d
    void SpawnNObstacles(int n)
    {
        for (int i = 0; i < n; i++)
        {
            Instantiate(prefabObstacle);
        }
    }
}
