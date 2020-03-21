using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovNubes : MonoBehaviour
{
    private Transform myPosition;
    public float speed;
    public float timeToDestroy;

    // Start is called before the first frame update
    void Start()
    {
        myPosition = GetComponent<Transform>();
        Destroy(gameObject, timeToDestroy);
    }

    // Update is called once per frame
    void Update()
    {
        myPosition.position = myPosition.position + (Vector3.right * speed * Time.deltaTime);
    }
}
