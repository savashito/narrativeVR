using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Base : MonoBehaviour
{
    public int completo;
    public GameObject mensaje;
    int piezas;
    private void Start()
    {
        piezas = 0;
    }
    

    public void AñadirPieza() {
        piezas = piezas + 1;
        if (piezas == completo) {
            mensaje.SetActive(true);
        }
    }

}
