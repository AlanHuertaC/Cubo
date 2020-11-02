
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour // MonoBehaviour es una clase que se hereda y es para el uso de componentes
{
    public float deltaRotacion = 30f; //Se declara publica para que aparezca en el editor de unity y se pueda modificar
    public float deltaMovimiento = 10f;
    public float R,G,B;
    public Color color;

    // Start is called before the first frame update
    void Start() // funcion que se llama una sola vez
    {
        /*Darle color al objeto*/
        //GetComponent<Renderer>().material.color = new Color(R,G,B);
        
        //GetComponent<Renderer>().material.color = color; // es lo mismo de la linea anterior solo que sin RGB
    }

    // Update is called once per frame
    void Update() // funcion que se llama por cada Frame
    {
        // transform.Rotate(new Vector3(10f, deltaRotacion, 30f) * Time.deltaTime); // la variable transform hace referencia a la posicion del componente    
        // Time.deltaTime ajusta los frames de acuerdo al ordenador que se tenga
        
        Rotar(); // para que verifique a cada rato si se pulsa una tecla
        Mover();
    }

    void Rotar()
    {
        //Para rotar la figura con el teclado 
        if (Input.GetKey(KeyCode.R))//deteccion de lo que se pulsa con el teclado 
        transform.Rotate(new Vector3(0f, deltaRotacion, 0f) * Time.deltaTime); // la variable transform hace referencia a la posicion del componente
        else if(Input.GetKey(KeyCode.T))//deteccion de lo que se pulsa con el teclado 
        transform.Rotate(new Vector3(0f, -deltaRotacion, 0f) * Time.deltaTime); // la variable transform hace referencia a la posicion del componente
        
    }

    void Mover()
    {
        //Para mover la figura con el teclado 
        if (Input.GetKey(KeyCode.W))//deteccion de lo que se pulsa con el teclado 
            //transform.Translate(Vector3.forward * -deltaMovimiento * Time.deltaTime); //se mueve de posicion
            transform.Translate(new Vector3(0f, deltaMovimiento, 0f) * Time.deltaTime); //Esta forma hace lo mismo que la anterior
            
        else if (Input.GetKey(KeyCode.S))//deteccion de lo que se pulsa con el teclado 
            //transform.Translate(Vector3.back * deltaMovimiento * Time.deltaTime); //se mueve de posicion
            transform.Translate(new Vector3(0f, -deltaMovimiento, 0f) * Time.deltaTime); //Esta forma hace lo mismo que la anterior

        else if (Input.GetKey(KeyCode.A))//deteccion de lo que se pulsa con el teclado 
            //transform.Translate(Vector3.left * deltaMovimiento * Time.deltaTime); //se mueve de posicion
            transform.Translate(new Vector3(-deltaMovimiento, 0f , 0f) * Time.deltaTime); //Esta forma hace lo mismo que la anterior

        else if (Input.GetKey(KeyCode.D))//deteccion de lo que se pulsa con el teclado 
            //transform.Translate(Vector3.right * deltaMovimiento * Time.deltaTime); //se mueve de posicion
            transform.Translate(new Vector3(deltaMovimiento, 0f, 0f) * Time.deltaTime); ///Esta forma hace lo mismo que la anterior

    }

}
