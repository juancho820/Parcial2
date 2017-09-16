using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controlador : MonoBehaviour {

    [SerializeField] GameObject enemigo1;
    [SerializeField] GameObject enemigo2;
    [SerializeField] GameObject enemigo3;

    GameObject enemigo;

    bool instanciadoa = false;
    bool instanciadob = false;
    bool instanciadoc = false;

    int rol=0;

    float tiempo;

    public int cambioDeTurno = 5;

	// Use this for initialization
	void Start () {


		
	}

    // Update is called once per frame
    void Update() {

        tiempo += Time.deltaTime;

        if(tiempo>= cambioDeTurno)
        {
            rol++;
            tiempo = 0;
        }

        switch (rol)
        {
            case 1:
                if(instanciadoa == false)
                {
                    enemigo = Instantiate(enemigo1);
                    instanciadoa = true;
                }
                enemigo.SetActive(true);
                break;
            case 2:
                if (instanciadob == false)
                {
                    enemigo = Instantiate(enemigo2);
                    instanciadob = true;
                }
                enemigo.SetActive(true);
                break;
            case 3:
                if (instanciadoc == false)
                {
                    enemigo = Instantiate(enemigo3);
                    instanciadoc = true;
                }
                enemigo.SetActive(true);
                break;
            case 4:
                rol = 1;
                instanciadoa = false;
                instanciadob = false;
                instanciadoc = false;
                break;
                


        }
		
	}
}
