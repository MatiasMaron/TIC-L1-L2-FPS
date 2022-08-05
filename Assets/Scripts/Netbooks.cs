using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Netbooks : MonoBehaviour
{
    public GameObject Netbook;
 

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Carrito"))
        {
            if (Input.GetKeyDown(KeyCode.N))
            {
                Instantiate(Netbook);
            }
        }
     
    }
}
