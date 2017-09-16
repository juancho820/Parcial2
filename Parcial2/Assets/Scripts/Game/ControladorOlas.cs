using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorOlas : MonoBehaviour {

    [SerializeField] GameObject enemigo1;
    [SerializeField] GameObject enemigo2;
    [SerializeField] GameObject enemigo3;

    public int enemigos=1;
    float tiempo;
    public int nuevaOleada = 5;

    GameObject enemigo;


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        tiempo += Time.deltaTime;

        if (tiempo >= nuevaOleada)
        {
            for (int i = 0; i < enemigos; i++)
            {
                enemigo = Instantiate(enemigo1);
                enemigo.SetActive(true);
                enemigo = Instantiate(enemigo2);
                enemigo.SetActive(true);
                enemigo = Instantiate(enemigo3);
                enemigo.SetActive(true);

            }
            tiempo = 0;

        }

    }
}
