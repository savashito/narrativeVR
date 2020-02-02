using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piezas : MonoBehaviour
{
    public GameObject padre;
    public GameObject mesa;
    public string tag;
    GameObject pieza;
    public Material matAzul;
    public Material matRojo;
    private void OnTriggerEnter(Collider other)
    {
        Renderer mesaRenderer = mesa.GetComponent<Renderer>();
        if (other.tag == tag) {
            Debug.Log("Chocando");
            mesaRenderer.material = matRojo;

            pieza = other.transform.parent.gameObject;
            pieza.transform.parent = padre.transform;
            /*Vector3 distancia = pieza.transform.position - padre.transform.position;
            Debug.Log("Posicion Base:" + padre.transform.position);
            Debug.Log("Posicion Pieza:" + pieza.transform.position);
            Debug.Log("Distancia:" + distancia);
            Collider caja = padre.GetComponent<Collider>();
            
            pieza.transform.position = pieza.transform.position - distancia + caja.bounds.size; */
            OVRGrabbable script = pieza.GetComponent<OVRGrabbable>();
            Destroy(script);
            Base comportamiento = padre.GetComponent<Base>();
            comportamiento.AñadirPieza();
            Destroy(this);
        }else
        {
            mesaRenderer.material = matAzul;

        }
    }

}
