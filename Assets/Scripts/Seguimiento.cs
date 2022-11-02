using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seguimiento : MonoBehaviour
{
    public GameObject jugador;
    private Rigidbody jugadorRb;
    // Start is called before the first frame update
    void Start()
    {
        jugadorRb = jugador.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position =new Vector3(jugador.transform.position.x,1.7f, jugador.transform.position.z);
    }
}
