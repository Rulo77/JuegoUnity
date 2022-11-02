using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class inicio : MonoBehaviour
{
    public GameObject texto;
    public Button boton;
    // Start is called before the first frame update
    void Start()
    {
        boton = GetComponent<Button>();
        boton.onClick.AddListener(click);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void click()
    {
        texto.gameObject.SetActive(false);
    }
}
