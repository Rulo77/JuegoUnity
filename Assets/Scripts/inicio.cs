using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class inicio : MonoBehaviour
{ 
    
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Iniciar()
    {
        SceneManager.LoadScene(1);
    }


    public void Salir()
    {
        Debug.Log("Saliendo del juego...");
        Application.Quit();
    }
}
