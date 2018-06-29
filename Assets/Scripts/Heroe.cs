using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NPC.Ally;
using NPC.Enemy;

public class Heroe : MonoBehaviour
{
   // ZombieE zombi;
   // CiudadanoE ciudadano;
    
	// Use this for initialization
	void Start ()
    {
        
       
    }
	
	// Update is called once per frame
	void Update ()
    {
        
       // Debug.Log("warrrr quiero comer " + zombi.partes);
	}

   void OnCollisionEnter (Collision colision) //Metodo que contiene los disparadores de mensajes para colisiones.
    {
        if (colision.gameObject.tag == "Zombie")
        {
            Debug.Log("warrrr quiero comer " + colision.gameObject.GetComponent<Zombie>().zombis.partes); //Colision para disparar el mensaje cuando entra en contacto con un zombie.
        }
        if (colision.gameObject.tag == "Ciudadano") //Colision para disparar el emnsaje cuando entra en contacto con un ciudadano.
        {
            Debug.Log("Hola soy " + colision.gameObject.GetComponent<Ciudadano>().citizen.nombres + " y Tengo " + colision.gameObject.GetComponent<Ciudadano>().citizen.edad + " de edad");
        }
    }
}
