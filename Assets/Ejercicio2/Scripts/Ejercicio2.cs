using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ejercicio2 : MonoBehaviour
{
    public Text miTexto;
    public GameObject estadoPausa;
    private List<string> frasesMotivacionales  = new List<string>()     {"Recuerda todos esos años de entrenamiento frente al PC",
                                                                        "Nunca una tarea fue tan simple, quedarse en casa",
                                                                        "El Animal Crossing ya esta aquí, tiene horas sin fin",
                                                                        "Si estas solo en casa, uno nunca está solo en internet",
                                                                        "Tranquilo que no te vas a aburrir, ahora tendrás el doble de trabajo"};
    private int contadorTexto = 0;
    private bool pausa = false;
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < frasesMotivacionales.Count; i++)
        {
            Debug.Log(frasesMotivacionales[i]);
        }
        InvokeRepeating("ImprimirMensaje", 0f, 10);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void ImprimirMensaje()
    {
        if (!pausa)
        {
            if (contadorTexto == frasesMotivacionales.Count)
                contadorTexto = 0;
            miTexto.text = frasesMotivacionales[contadorTexto];
            contadorTexto++;
        }
    }

    public void CambiarTexto()
    {
        int x = Random.Range(0, 5);
        miTexto.text = frasesMotivacionales[x];
    }

    public void PausarTexto()
    {
        pausa = !pausa;
        estadoPausa.gameObject.SetActive(pausa);
    }
}
