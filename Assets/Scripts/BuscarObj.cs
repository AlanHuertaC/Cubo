using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuscarObj : MonoBehaviour
{
    void Awake()//Se usa para encontrar objetos o componentes de los objetos 
    {
        /*Busqueda del componente por nombre*/
        GameObject camara = GameObject.Find("Main Camera"); //es la camara que se encuentra en la escena 
        Debug.Log("La posicion de la camara es: " + camara.transform.position); // debugeamos la camara e imprimimos la posicion en consola

        /*Busqueda del componente por tag*/
        GameObject camara2 = GameObject.FindGameObjectWithTag("MainCamera");
        Debug.Log("Camara 2 en la posicion: " + camara2.transform.position);

        /*Forma de obtener la camara principal*/
        GameObject camaraPrincipal = Camera.main.gameObject;
        Debug.Log("Esta es la camara principal del juego");

        /*Busqueda de arreglo de Objetos*/
        GameObject [] objects = GameObject.FindGameObjectsWithTag("TagObjetos");
        foreach(GameObject go in objects)
        Debug.Log("Objeto con la posicion: "+ go.transform.position);
        /*Forma tradicioanl del for*/
        for(int i=0; i<objects.Length; i++)
        Debug.Log("Objeto con la posicion: "+ objects[i].gameObject.transform.position);

    }
}
