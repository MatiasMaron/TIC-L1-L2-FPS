using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumerosAlAzar : MonoBehaviour
{
    [SerializeField]int randomNumber;

    // Start is called before the first frame update
    void Start()
    {
        if(Input.GetKeyDown(KeyCode.P))
        {
            GenerarNumeroAleatorio();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void GenerarNumeroAleatorio()
    {
        randomNumber = Random.Range(0, 4);
    }
}
