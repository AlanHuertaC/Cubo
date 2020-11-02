using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controlador : MonoBehaviour
{
    void Awake()
    {
        /*Busca si el script1 esta en el obj camara*/
        Script1 s1 = Camera.main.GetComponent<Script1>(); //s1 ya es la instancia de la clase Script1
        Debug.Log(s1);

        /*Busqueda del Script 2 en el componente que lo tenga*/
        Script2 s2 = gameObject.GetComponentInChildren<Script2>(); // se puede buscar el Componente porque pertenece a un hijo
        //Cuando encuentre el componente dira que hijo lo tiene
        Debug.Log(s2);

        Script3[] s3 = gameObject.GetComponentsInChildren<Script3>(); //Busca en todos los hijos y regresa los que tienen el Script
        Debug.Log(s3);
    }
}
