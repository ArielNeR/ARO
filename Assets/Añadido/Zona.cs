using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zona : MonoBehaviour
{
    public Material material;
    public GameObject objeto;

    private Material[] materialesGuardados;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            Renderer rendererObjeto = objeto.GetComponent<Renderer>();
            materialesGuardados = rendererObjeto.materials;
            Material[] nuevosMateriales = new Material[]{ material,material};
            rendererObjeto.materials = nuevosMateriales;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            Renderer rendererObjeto = objeto.GetComponent<Renderer>();
            rendererObjeto.materials = materialesGuardados;
        }
    }

}
