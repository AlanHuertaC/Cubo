using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoFisica : MonoBehaviour
{
    public float velocidad = 10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
     Rigidbody rigidbody = gameObject.GetComponent<Rigidbody>();   
     if(Input.GetKey(KeyCode.UpArrow))
        GetComponent<Rigidbody>().MovePosition(rigidbody.position + Vector3.forward * velocidad * Time.deltaTime); 

     if(Input.GetKey(KeyCode.DownArrow))
        GetComponent<Rigidbody>().MovePosition(rigidbody.position + Vector3.back * velocidad * Time.deltaTime);

     if(Input.GetKey(KeyCode.LeftArrow))
        GetComponent<Rigidbody>().MovePosition(rigidbody.position + Vector3.left * velocidad * Time.deltaTime);

     if(Input.GetKey(KeyCode.RightArrow))
        GetComponent<Rigidbody>().MovePosition(rigidbody.position + Vector3.right * velocidad * Time.deltaTime);
    }

    /*Indica cuando hace la colision*/
   /* void OnCollisionEnter(Collision collision){ //se manda a llamar despues del FixedUpdate pero antes que el update
        Debug.Log(collision.gameObject.name); // nos dice con que objeto esta colisionando
    }*/
    /*Indica todo el tiempo que esta colisionando*/
    /* void OnCollisionStay(Collision collision){ //se manda a llamar despues del FixedUpdate pero antes que el update
        Debug.Log(collision.gameObject.name); // nos dice con que objeto esta colisionando
    }*/

    /*Nos dice cuando la coliision acabo*/
    /* void OnCollisionExit(Collision collision){ //se manda a llamar despues del FixedUpdate pero antes que el update
        Debug.Log(collision.gameObject.name); // nos dice con que objeto esta colisionando
    }*/

    /*Triggers*/
    /*Cuando se toca el area del trigger*/
    /*void OnTriggerEnter(Collider collider)
    {
        Debug.Log("LLegaste al  check point" + collider.gameObject.name);
    }*/

    /*Cuando permaneces en el trigger*/
    /*void OnTriggerStay(Collider collider)
    {
        Debug.Log("Sigues en el check point" + collider.gameObject.name);
    }*/

    /*Cuando sales del area del trigger*/
    void OnTriggerExit(Collider collider)
    {
        Debug.Log("Saliste del check point" + collider.gameObject.name);
    }
}
