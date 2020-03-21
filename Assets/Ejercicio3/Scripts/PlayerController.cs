
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{

    public Rigidbody2D rigidBody2D;
    public float speed = 100f;
    public Text textoRupias;
    public GameObject panelMuerte;

    private int rupias;
    private float direction;
    private bool isDead;


    private void Start()
    {
        rupias = 0;
        textoRupias.text = rupias.ToString();
        Time.timeScale = 1f;
    }

    void Update()
    {
        direction = Input.GetAxisRaw("Horizontal");
    }

    private void FixedUpdate()
    {
        rigidBody2D.velocity = Vector2.zero;
        rigidBody2D.velocity = new Vector2(direction * speed * Time.fixedDeltaTime, 0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (PlayerPrefs.GetInt("highscore") < rupias)
        {
            PlayerPrefs.SetInt("highscore", rupias);
        }
        if (collision.gameObject.CompareTag("Coin"))
        {
            rupias += 1;
            collision.gameObject.SetActive(false);

        }

        if (collision.gameObject.CompareTag("Obstacle"))
        {
            rupias=rupias-2;
            if (rupias < 0)
            {
                rupias = 0;
                Morir();
            }
            collision.gameObject.SetActive(false);

        }
        print(rupias);
        textoRupias.text = rupias.ToString();
    }

    private void Morir()
    {
        isDead = true;
        panelMuerte.SetActive(true);
        Time.timeScale = 0.5f;

        StartCoroutine(Esperar(0.5f));


    }

    IEnumerator Esperar(float time)
    {
        yield return new WaitForSecondsRealtime(time);
        Time.timeScale = 0f;
    }
}
