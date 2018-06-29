﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSmove : FPSAim //Herencia del script FPSAim
{
     //Variable que controla la velocidad del movimiento del player.
    public HeroeE heroeInfo;
    // Use this for initialization
    void Start () {


        heroeInfo.speed = Random.Range(0.1f, 0.3f); //Valor de la velocidad del movimiento del player.
}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.W)) //Control de direccion para moverse hacia adelante.
        {
             transform.position += transform.forward*heroeInfo.speed;
        }
        if (Input.GetKey(KeyCode.S)) //Control de direccion para moverse hacia atras.
        {
            transform.position -= transform.forward* heroeInfo.speed; 
        }
        if (Input.GetKey(KeyCode.A)) //Control de direccion para moverse hacia la izquierda.
        {
            transform.position -= transform.right * heroeInfo.speed;
        }
        if (Input.GetKey(KeyCode.D)) //Control de direccion para moverse hacia la derecha.
        {
            transform.position += transform.right * heroeInfo.speed;
        }
        giro(); //Llamada a la clase giro heredada del scrip FPSAim para girar el player al tiempo que se gira la camara.
    }
}
