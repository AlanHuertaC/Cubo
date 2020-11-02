using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntanciaObj : MonoBehaviour
{
    public GameObject prefab;
    private int count = 0;
    // Start is called before the first frame update
    void Start()
    {
        /*Funcion para instanciar GameObjects*/
        //System.Threading.Thread.Sleep(5000);
        //Instantiate(prefab, transform.position, transform.rotation); // Instancia el el objeto con el posicion y rotacion
   
    }
    
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {        
        /*Instancia objetos al apretar la flecha izq*/            
        GameObject cubo= Instantiate(prefab, transform.position, transform.rotation) as GameObject; // Instancia el el objeto con el posicion y rotacion
        cubo.name = "Cubito" + ++count;
        Fisicas f = cubo.GetComponent<Fisicas>();
        f.Disparo();      
        /*Destruye cualquier objeto*/
        Destroy(cubo,3f); //define el tiempo en el que se destruye                
        }
    }

}
