using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour
{

    public int velocidad = 5;
    private float InputX;
    public float InputZ;
    private int FuerzaSalto = 3;
    private Rigidbody JugadorRB;
    private float salto;
    private bool puedoSaltar;
    // Start is called before the first frame update
    void Start()
    {
        JugadorRB = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        InputX = Input.GetAxis("Horizontal");
        InputZ = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * Time.deltaTime * velocidad * InputZ);

        transform.Translate(Vector3.right * Time.deltaTime * velocidad * InputX);

        if (puedoSaltar)
        {
            puedoSaltar = false;
            JugadorRB.AddForce(Vector3.up * FuerzaSalto, ForceMode.Impulse);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Piso"))
        {

            puedoSaltar = true;
        }
    }
}
