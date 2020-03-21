using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoTrollFace : MonoBehaviour
{
    private Transform myPosition;
    private float speed = 5;
    private float timeToDestroy = 1;
    private int random;

    // Start is called before the first frame update
    void Start()
    {
        random = Random.Range(0, 8);
        myPosition = GetComponent<Transform>();
        Destroy(gameObject, timeToDestroy);
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        switch (random)
        {
            case 0:
                myPosition.position = myPosition.position + (Vector3.left * speed * Time.deltaTime);
                break;
            case 1:
                myPosition.position = myPosition.position + ((Vector3.left + Vector3.up) * speed * Time.deltaTime);
                break;
            case 2:
                myPosition.position = myPosition.position + (Vector3.up * speed * Time.deltaTime);
                break;
            case 3:
                myPosition.position = myPosition.position + ((Vector3.right + Vector3.up) * speed * Time.deltaTime);
                break;
            case 4:
                myPosition.position = myPosition.position + (Vector3.right * speed * Time.deltaTime);
                break;
            case 5:
                myPosition.position = myPosition.position + ((Vector3.right + Vector3.down) * speed * Time.deltaTime);
                break;
            case 6:
                myPosition.position = myPosition.position + (Vector3.down * speed * Time.deltaTime);
                break;
            case 7:
                myPosition.position = myPosition.position + ((Vector3.left + Vector3.down) * speed * Time.deltaTime);
                break;
        }
    }
}
