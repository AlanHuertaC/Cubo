using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fisicas : MonoBehaviour
{
    // Start is called before the first frame update
    /*void Start()    
    {
        float x = Random.Range(-1f,1f); //Genera numeros aleatorios        
        GetComponent<Rigidbody>().AddForce(new Vector3 (x, 0f, 1f)* 100, ForceMode.Impulse);     
    }*/
    public void Disparo()    
    {
        float x = Random.Range(-1f,1f); //Genera numeros aleatorios
        /*Fuerzas Instantaneas*/
        /*Ejemplo de aplicar una fuerza Instantanea usando la masa del obj*/
        //GetComponent<Rigidbody>().AddForce(Vector3.right * 50f, ForceMode.Impulse);//Aplicando fuerza usando la masa
        GetComponent<Rigidbody>().AddForce(new Vector3 (x, 0f, 1f)* 100, ForceMode.Impulse);     
        /*Ejemplo de aplicar una fuerza Instantanea SIN USAR la masa del obj*/
        //GetComponent<Rigidbody>().AddForce(Vector3.right * 50f, ForceMode.VelocityChange);
    
    }

    // Update is called once per frame
    void Update() //se usa en vez de Update por que se estan usando fisicas, para omitir Time.deltaTime
    {
        /*Fuerzas Continuas*/
        /*Ejemplo de aplicar una fuerza Continua usando la masa del obj*/
        //GetComponent<Rigidbody>().AddForce(Vector3.left * 50f, ForceMode.Force);
        //GetComponent<Rigidbody>().AddForce(Vector3.one * 50f, ForceMode.Force); // Con Vector3.one se le aplica fuerza en las 3 direcciones
        //GetComponent<Rigidbody>().AddForce(Vector3.up * 50f, ForceMode.Force);
        /*Ejemplo de aplicar una fuerza Instantanea SIN USAR la masa del obj*/
        //GetComponent<Rigidbody>().AddForce(Vector3.left * 50f, ForceMode.Acceleration);
    }
}
