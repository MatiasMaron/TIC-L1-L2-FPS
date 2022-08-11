using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManipularObjetos : MonoBehaviour
{
    [SerializeField]GameObject[] sillas;
    
    void Start()
    {
        sillas = GameObject.FindGameObjectsWithTag("Silla");
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Backspace))
        {
            //DesactivarElementosDelArray();
            AgregarRBAElementosDelArray();
            AgregarBCAElementosDelArray();
        }
    }

    void DesactivarElementosDelArray()
    {
        for(int i = 0;i<sillas.Length;i++)
        {
            sillas[i].SetActive(false);
        }
    }

    void AgregarRBAElementosDelArray()
    {
        for (int i = 0;i<sillas.Length;i++)
        {
            sillas[i].AddComponent<Rigidbody>();
        }
    }

    void AgregarBCAElementosDelArray()
    {
        for (int i = 0; i < sillas.Length; i++)
        {
            sillas[i].AddComponent<BoxCollider>();
        }
    }


}
