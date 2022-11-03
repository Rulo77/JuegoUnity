using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Jugador : MonoBehaviour
{
    public TextMeshProUGUI texto;
    private bool canPlay = true;
    public int velocidad = 4;
    private float InputX;
    public float InputZ;
    private int FuerzaSalto = 7;
    private Rigidbody JugadorRB;
    private float salto;
    private bool puedoSaltar;
    private float vida = 50;
    public Canvas canvas;
    // Start is called before the first frame update
    void Start()
    {
        JugadorRB = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (canPlay)
        {
            texto.text = vida.ToString("0");
            InputX = Input.GetAxis("Horizontal");
            InputZ = Input.GetAxis("Vertical");

            transform.Translate(Vector3.forward * Time.deltaTime * velocidad * InputZ);

            transform.Translate(Vector3.right * Time.deltaTime * velocidad * InputX);

            if (transform.position.y<=0)
            {
                Reiniciar();
            }

            if (puedoSaltar && Input.GetKey(KeyCode.Space))
            {
                puedoSaltar = false;
                JugadorRB.AddForce(Vector3.up * FuerzaSalto, ForceMode.Impulse);
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Piso"))
        {
            puedoSaltar = true;
        }
       
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Fin"))
        {
            canPlay = false;
            canvas.gameObject.SetActive(true);
           
        }
        if (other.gameObject.CompareTag("Enemigo"))
        {
            vida -= 5;
            if (vida <= 0)
            {
             
                canPlay = false;
                Reiniciar();
            }
        }
    }

    public void Reiniciar()
    {
        SceneManager.LoadScene("MenuInicio");
    }
}
